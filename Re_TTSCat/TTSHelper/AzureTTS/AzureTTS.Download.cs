using NAudio.Wave;
using Re_TTSCat.Data;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Re_TTSCat
{
    public static class AzureTTS
    {
        public static async Task<string> Download(string content)
        {
            {
                var errorCount = 0;
                var AzureTtsUrl = Vars.ApiAzure.Replace("$REGION", Vars.CurrentConf.BaiduApiKey);
                var contentType = "application/ssml+xml";
                var userAgent = "RE-TTSCat";
                var outputFormat = "audio-16khz-128kbitrate-mono-mp3";
                var TtsContnet = "<speak version='1.0' xml:lang='en-US'>" +
                   "<voice name='zh-CN-XiaoxiaoNeural'>" +
                   content +
                   "</voice>" +
                   "</speak>";
            Retry:
                try
                {
                    var fileName = Path.Combine(Vars.CacheDir, Conf.GetRandomFileName() + "AZRE.mp3");
                    Bridge.ALog("(E7) 正在下载 TTS, 文件名: " + fileName);
                    using (var downloader = new HttpClient())
                    {
                        downloader.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Vars.CurrentConf.BaiduApiSecretKey);
                        downloader.DefaultRequestHeaders.Add("User-Agent", userAgent);
                        downloader.DefaultRequestHeaders.Add("X-Microsoft-OutputFormat", outputFormat);

                        var requestBody = new StringContent(TtsContnet, Encoding.UTF8, contentType);

                        var response = await downloader.PostAsync(AzureTtsUrl, requestBody);
                        if (response.IsSuccessStatusCode)
                        {
                            var responseBytes = await response.Content.ReadAsByteArrayAsync();
                            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                            {
                                await fs.WriteAsync(responseBytes, 0, responseBytes.Length);
                            }
                            Bridge.ALog("(E7)The audio was saved successfully!");
                        }
                        else
                        {
                            Bridge.ALog($"(E7)Failed to generate speech. Status code: {response.StatusCode}");
                        }

                        // validate if file is playable
                        using (var reader = new AudioFileReader(fileName)) { }
                        return fileName;
                    }
                }
                catch (Exception ex)
                {
                    Bridge.ALog("(E7) TTS 下载失败: " + ex.Message);
                    errorCount += 1;
                    Vars.TotalFails++;
                    if (errorCount <= Vars.CurrentConf.DownloadFailRetryCount)
                    {
                        goto Retry;
                    }
                    return null;
                }
            }
        }
    }
}
