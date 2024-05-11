﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Re_TTSCat.Data
{
    public partial class Conf
    {
        public Conf()
        {
            AutoUpdate = true;
            BlackList = "";
            WhiteList = "";
            BlockMode = 0;
            GiftBlockMode = 0;
            KeywordBlockMode = 0;
            BlockUID = true;
            DebugMode = false;
            DownloadFailRetryCount = 5;
            DoNotKeepCache = false;
            Engine = 0;
            GiftBlackList = "";
            GiftWhiteList = "";
            KeywordBlackList = "";
            KeywordWhiteList = "";
            MinimumDanmakuLength = 0;
            MaximumDanmakuLength = 50;
            ReadInQueue = true;
            ReadPossibility = 100;
            TTSVolume = 100;
            ReadSpeed = 0;
            try
            {
                using (var synth = new SpeechSynthesizer())
                {
                    Vars.SystemSpeechAvailable = true;
                    var voice = synth.GetInstalledVoices().FirstOrDefault(x => x.Enabled);
                    if (voice == default) VoiceName = "(无可用语音包)";
                    VoiceName = voice.VoiceInfo.Name;
                }
            }
            catch (Exception ex)
            {
                Vars.SystemSpeechAvailable = false;
                Vars.SpeechUnavailableString = ex.ToString();
            }
            UseGoogleGlobal = false;
            AllowDownloadMessage = false;
            AllowConnectEvents = true;
            ClearQueueAfterDisconnect = true;
            CatchGlobalError = true;
            SuperChatIgnoreRandomDitch = true;
            SaveCacheInTempDir = true;
            SuppressLogOutput = false;
            ClearCacheOnStartup = true;
            OverrideToLogsTabOnStartup = false;
            AutoStartOnLoad = false;
            SpeechPerson = 0;
            EnableVoiceReply = false;
            InstantVoiceReply = false;
            MinifyJson = true;
            SpeechPitch = 0;
            GiftsThrottle = true;
            GiftsThrottleDuration = 3;
            EnableUrlEncode = true;
            VoiceReplyFirst = false;
            IgnoreIfHitVoiceReply = false;
            DeviceGuid = DefaultDeviceGuid;
            AutoFallback = true;
            UseDirectSound = true;
            FullyAutomaticUpdate = true;
            AutoBaiduFallback = true;
            HttpAuth = false;
            HttpAuthPassword = "";
            HttpAuthUsername = "";
            Headers = new List<Header>();
            ReqType = RequestType.JustGet;
            PostData = "";
            BaiduApiKey = "";
            BaiduApiSecretKey = "";

            CustomEngineURL = "https://tts.example.com/?text=$TTSTEXT";
            OnConnected = "已成功连接至房间: $ROOM";
            OnDisconnected = "已断开连接: $ERROR";
            OnDanmaku = "$USER 说: $DM";
            OnSuperChat = "$USER 发送了醒目留言: $DM";
            OnGift = "收到来自 $USER 的 $COUNT 个 $GIFT";
            OnGuardBuy = "$USER 上船了 $COUNT 月";
            OnLiveStart = "直播已开始";
            OnLiveEnd = "直播已结束";
            OnWelcome = "欢迎老爷: $USER";
            OnWelcomeGuard = "欢迎船员: $USER";
            OnWarning = "直播间收到超管警告";
            CustomVIP = "老爷";
            CustomGuardLevel0 = "用户";
            CustomGuardLevel1 = "总督";
            CustomGuardLevel2 = "提督";
            CustomGuardLevel3 = "舰长";
            OnInteractEnter = "欢迎 $USER 进入直播间";
            OnInteractFollow = "感谢 $USER 关注直播间";
            OnInteractMutualFollow = "感谢 $USER 的互关";
            OnInteractShare = "感谢 $USER 分享直播间";
            OnInteractSpecialFollow = "感谢 $USER 的特别关注";
            VoiceReplyRules = new List<VoiceReplyRule>();
        }
    }
}
