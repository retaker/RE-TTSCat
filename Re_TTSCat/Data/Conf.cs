﻿using System;
using System.Collections.Generic;

namespace Re_TTSCat.Data
{
    public partial class Conf
    {
        // sorry, have to rip that off https://github.com/naudio/NAudio/blob/master/NAudio/Wave/WaveOutputs/DirectSoundOut.cs
        // because this part of code should be independent on NAudio
        public static readonly Guid DefaultDeviceGuid = new Guid("DEF00000-9C6D-47ED-AAF1-4DDA8F2B5C03");

        /// <summary>
        /// 是否启用自动更新
        /// </summary>
        public bool AutoUpdate { get; set; }
        /// <summary>
        /// 黑名单
        /// </summary>
        public string BlackList { get; set; }
        /// <summary>
        /// 白名单
        /// </summary>
        public string WhiteList { get; set; }
        /// <summary>
        /// 屏蔽模式<br/>
        /// 0 = 已关闭, 1 = 黑名单, 2 = 白名单
        /// </summary>
        public byte BlockMode { get; set; }
        /// <summary>
        /// 礼物屏蔽模式<br/>
        /// 0 = 已关闭, 1 = 黑名单, 2 = 白名单
        /// </summary>
        public byte GiftBlockMode { get; set; }
        /// <summary>
        /// 关键字屏蔽模式<br/>
        /// 0 = 已关闭, 1 = 黑名单, 2 = 白名单, 3 = 正则表达式黑名单, 4 = 正则表达式白名单
        /// </summary>
        public byte KeywordBlockMode { get; set; }
        /// <summary>
        /// true = 黑名单中为 UID<br/>
        /// false = 黑名单中为用户名
        /// </summary>
        public bool BlockUID { get; set; }
        /// <summary>
        /// 是否启用插件调试模式
        /// </summary>
        public bool DebugMode { get; set; }
        /// <summary>
        /// 下载失败的重试次数
        /// </summary>
        public byte DownloadFailRetryCount { get; set; }
        /// <summary>
        /// 是否在播放完成后立即删除缓存文件
        /// </summary>
        public bool DoNotKeepCache { get; set; }
        /// <summary>
        /// 要使用的弹幕引擎<br/>
        /// 0 = 毒瘤, 1 = .NET, 2 = Does not exist, 3 = 毒瘤 广东话, 4 = 有道, 5 = 用户自定义, 6 = 毒瘤高级版
        /// </summary>
        public byte Engine { get; set; }
        /// <summary>
        /// 礼物黑名单
        /// </summary>
        public string GiftBlackList { get; set; }
        /// <summary>
        /// 礼物白名单
        /// </summary>
        public string GiftWhiteList { get; set; }
        /// <summary>
        /// 关键字黑名单
        /// </summary>
        public string KeywordBlackList { get; set; }
        /// <summary>
        /// 关键字白名单
        /// </summary>
        public string KeywordWhiteList { get; set; }
        /// <summary>
        /// 最小弹幕字数
        /// </summary>
        public int MinimumDanmakuLength { get; set; }
        /// <summary>
        /// 最大弹幕字数
        /// </summary>
        public int MaximumDanmakuLength { get; set; }
        /// <summary>
        /// 是否逐个朗读
        /// </summary>
        public bool ReadInQueue { get; set; }
        /// <summary>
        /// 弹幕朗读概率 (0~100)
        /// </summary>
        public int ReadPossibility { get; set; }
        /// <summary>
        /// 读出速度（仅适用于 .NET 框架引擎，范围 -10 ~ 10）<br />
        /// 百度：转换为 0 ~ 15, 5 为正常语速
        /// </summary>
        public int ReadSpeed { get; set; }
        /// <summary>
        /// 系统语音名称
        /// </summary>
        public string VoiceName { get; set; }
        /// <summary>
        /// TTS 音量 (0~100, 调用时转换为 /100 后的 float)
        /// </summary>
        public int TTSVolume { get; set; }
        /// <summary>
        /// 是否适用 Google 国际服务器
        /// </summary>
        public bool UseGoogleGlobal { get; set; }
        /// <summary>
        /// 用户自定义 TTS 引擎地址，用 $TTSTEXT 表示读出内容
        /// </summary>
        public string CustomEngineURL { get; set; }
        /// <summary>
        /// 允许下载推送消息
        /// </summary>
        public bool AllowDownloadMessage { get; set; }
        /// <summary>
        /// 允许处理连接/断开事件
        /// </summary>
        public bool AllowConnectEvents { get; set; }
        /// <summary>
        /// 在断开连接时清空待朗读 TTS
        /// </summary>
        public bool ClearQueueAfterDisconnect { get; set; }
        /// <summary>
        /// 捕捉全局错误
        /// </summary>
        public bool CatchGlobalError { get; set; }
        /// <summary>
        /// 醒目留言是否无视随机朗读设定
        /// </summary>
        public bool SuperChatIgnoreRandomDitch { get; set; }
        /// <summary>
        /// 是否在临时文件夹保存缓存
        /// </summary>
        public bool SaveCacheInTempDir { get; set; }
        /// <summary>
        /// 压制日志输出
        /// </summary>
        public bool SuppressLogOutput { get; set; }
        /// <summary>
        /// 在启动时清理缓存
        /// </summary>
        public bool ClearCacheOnStartup { get; set; }
        /// <summary>
        /// 在启动时强行切换到首页
        /// </summary>
        public bool OverrideToLogsTabOnStartup { get; set; }
        /// <summary>
        /// 在弹幕姬启动时自动启动插件
        /// </summary>
        public bool AutoStartOnLoad { get; set; }
        /// <summary>
        /// 百度 AI 引擎的朗读人物<br/>
        /// 0 = 度小美, 1 = 度小宇, 2 = 度逍遥, 3 = 度丫丫, 4 = 度小娇, 5 = 度米朵, 6 = 度博文, 7 = 度小童, 8 = 度小萌
        /// </summary>
        public int SpeechPerson { get; set; }
        /// <summary>
        /// 是否启用语音答复
        /// </summary>
        public bool EnableVoiceReply { get; set; }
        /// <summary>
        /// 是否立即读出语音答复而不排队
        /// </summary>
        public bool InstantVoiceReply { get; set; }
        /// <summary>
        /// 是否简化 JSON
        /// </summary>
        public bool MinifyJson { get; set; }
        /// <summary>
        /// 百度高级版 TTS 的语调，0 至 15<br />
        /// 可使用 <see cref="BaiduTTS.ConvertSpeed(double)"/> 函数来从 -10 至 10 转换
        /// </summary>
        public int SpeechPitch { get; set; }
        /// <summary>
        /// 是否合并短时间内的礼物
        /// </summary>
        public bool GiftsThrottle { get; set; }
        /// <summary>
        /// 礼物合并时长
        /// </summary>
        public int GiftsThrottleDuration { get; set; }
        /// <summary>
        /// 启用 URL 编码
        /// </summary>
        public bool EnableUrlEncode { get; set; }
        /// <summary>
        /// 是否优先读出语音答复
        /// </summary>
        public bool VoiceReplyFirst { get; set; }
        /// <summary>
        /// 命中语音回复时是否取消对应事件朗读
        /// </summary>
        public bool IgnoreIfHitVoiceReply { get; set; }
        /// <summary>
        /// 音频输出设备 GUID
        /// </summary>
        public Guid DeviceGuid { get; set; }
        /// <summary>
        /// 是否失败时自动回落到默认设备
        /// </summary>
        public bool AutoFallback { get; set; }
        /// <summary>
        /// 是否使用 DirectSound 输出
        /// </summary>
        public bool UseDirectSound { get; set; }
        /// <summary>
        /// 全自动更新
        /// </summary>
        public bool FullyAutomaticUpdate { get; set; }
        /// <summary>
        /// 百度高级版密钥为空时自动回落，仅检查公钥
        /// </summary>
        public bool AutoBaiduFallback { get; set; }
        /// <summary>
        /// 是否启用 HTTP 身份验证
        /// </summary>
        public bool HttpAuth { get; set; }
        /// <summary>
        /// HTTP 身份验证用户名
        /// </summary>
        public string HttpAuthUsername { get; set; }
        /// <summary>
        /// HTTP 身份验证密码
        /// </summary>
        public string HttpAuthPassword { get; set; }
        /// <summary>
        /// 自定义请求头集合
        /// </summary>
        public List<Header> Headers { get; set; }
        /// <summary>
        /// POST 请求方法
        /// </summary>
        public RequestType ReqType { get; set; }
        /// <summary>
        /// POST 数据内容，若为 multipart formdata 则使用 base64 编码
        /// </summary>
        public string PostData { get; set; }
        /// <summary>
        /// 百度 API 公钥 / Azure Region Code
        /// </summary>
        public string BaiduApiKey { get; set; }
        /// <summary>
        /// 百度 API 私钥 / Azure Application Key
        /// </summary>
        public string BaiduApiSecretKey { get; set; }
        /// <summary>
        /// Azure Voice Name
        /// </summary>
        public string AzureVoiceName { get; set; }

        /// <summary>
        /// 在连接成功后读出的内容，留空以禁用
        /// </summary>
        public string OnConnected { get; set; }
        /// <summary>
        /// 在断线时读出的内容，留空以禁用
        /// </summary>
        public string OnDisconnected { get; set; }
        /// <summary>
        /// 自定义弹幕读出内容，留空以禁用
        /// </summary>
        public string OnDanmaku { get; set; }
        /// <summary>
        /// 自定义醒目留言读出内容，留空以禁用
        /// </summary>
        public string OnSuperChat { get; set; }
        /// <summary>
        /// 自定义礼物读出内容，留空以禁用
        /// </summary>
        public string OnGift { get; set; }
        /// <summary>
        /// 购买船票文本，留空以禁用
        /// </summary>
        public string OnGuardBuy { get; set; }
        /// <summary>
        /// 直播开始文本，留空以禁用
        /// </summary>
        public string OnLiveStart { get; set; }
        /// <summary>
        /// 直播结束文本，留空以禁用
        /// </summary>
        public string OnLiveEnd { get; set; }
        /// <summary>
        /// 欢迎老爷文本，留空以禁用
        /// </summary>
        public string OnWelcome { get; set; }
        /// <summary>
        /// 超管警告文本，留空以禁用
        /// </summary>
        public string OnWarning { get; set; }
        /// <summary>
        /// 欢迎船员文本，留空以禁用
        /// </summary>
        public string OnWelcomeGuard { get; set; }
        /// <summary>
        /// 自定义非船员头衔
        /// </summary>
        public string CustomGuardLevel0 { get; set; }
        /// <summary>
        /// 自定义总督头衔
        /// </summary>
        public string CustomGuardLevel1 { get; set; }
        /// <summary>
        /// 自定义提督头衔
        /// </summary>
        public string CustomGuardLevel2 { get; set; }
        /// <summary>
        /// 自定义舰长头衔
        /// </summary>
        public string CustomGuardLevel3 { get; set; }
        /// <summary>
        /// 自定义老爷头衔
        /// </summary>
        public string CustomVIP { get; set; }
        /// <summary>
        /// 进入房间时的读出内容
        /// </summary>
        public string OnInteractEnter { get; set; }
        /// <summary>
        /// 当用户关注时的读出内容
        /// </summary>
        public string OnInteractFollow { get; set; }
        /// <summary>
        /// 当用户互相关注时的读出内容
        /// </summary>
        public string OnInteractMutualFollow { get; set; }
        /// <summary>
        /// 当用户分享直播间时的读出内容
        /// </summary>
        public string OnInteractShare { get; set; }
        /// <summary>
        /// 当用户特别关注时的读出内容
        /// </summary>
        public string OnInteractSpecialFollow { get; set; }
        /// <summary>
        /// 语音答复规则列表
        /// </summary>
        public List<VoiceReplyRule> VoiceReplyRules { get; set; }
    }
}
