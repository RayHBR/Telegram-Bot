using System;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using System.Net.Http;


namespace Microsoft.Bot.Sample.SimpleEchoBot
{
    [Serializable]
    public class EchoDialog : IDialog<object>
    {
        protected int count = 1;

        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            int length = (activity.Text ?? string.Empty).Length;
            Random Yu = new Random();
            string[] YuReply = { "松獅犬4ni", "獅子丸4ni", "柯基犬4ni", "肥肚肚", "松獅犬", "獅子丸", "柯基犬" };
            int YuIndex = Yu.Next(0, YuReply.Length);
            Random Zi = new Random();
            string[] ZiReply = { "元智林俊傑", "元智林俊傑4ni", "唱歌！唱歌！" };
            int ZiIndex = Zi.Next(0, ZiReply.Length);
            Random Ye = new Random();
            string[] YeReply = { "楷yeeeeeeee", "yeeeee", "恐龍4ni", "恐龍yeeeeee" };
            int YeIndex = Ye.Next(0, YeReply.Length);
            Random Yee = new Random();
            string[] YeeReply = { "@kaiyeee: 4ni!!!", "是翊不是yee!!!!" };
            int YeeIndex = Yee.Next(0, YeeReply.Length);
            Random moon = new Random();
            string[] moonReply = { "🌕🌖🌗🌘🌑🌒🌓🌔🌕", "🌑🌒🌓🌔🌕🌖🌗🌘🌑", "🌕🌖🌗🌘🌑", "🌑🌒🌓🌔🌕" };
            int moonIndex = moon.Next(0, moonReply.Length);
            Random weather = new Random();
            string[] weatherReply = { "☀️🌤⛅️🌥☁️🌦🌧⛈🌩⚡️", "☀️🌤⛅️🌥☁️", "☁️🌦🌧⛈🌩⚡️" };
            int weatherIndex = weather.Next(0, weatherReply.Length);
            string zodiacReply = "🐭🐮🐯🐰🐲🐍🐴🐐🐒🐓🐕🐷";
            if (length != 0)
            {
                if (Regex.IsMatch(activity.Text, "裕翔"))
                {
                    await context.PostAsync(text: YuReply[YuIndex]);
                }
                if (Regex.IsMatch(activity.Text, "子軒"))
                {
                    await context.PostAsync(text: ZiReply[ZiIndex]);
                }
                if (Regex.IsMatch(activity.Text, "楷翊"))
                {
                    await context.PostAsync(text: YeReply[YeIndex]);
                }
                else if (Regex.IsMatch(activity.Text, "yee"))
                {
                    await context.PostAsync(text: YeeReply[YeeIndex]);
                }
                if (Regex.IsMatch(activity.Text, "月亮"))
                {
                    await context.PostAsync(text: moonReply[moonIndex]);
                }
                if (Regex.IsMatch(activity.Text, "天氣"))
                {
                    await context.PostAsync(text: weatherReply[weatherIndex]);
                }
                if (Regex.IsMatch(activity.Text, "生宵"))
                {
                    await context.PostAsync(text: zodiacReply);
                }
                if (Regex.IsMatch(activity.Text, "去死"))
                {
                    await context.PostAsync(text: "你才去死膩!");
                }
                else if (Regex.IsMatch(activity.Text, "有病"))
                {
                    await context.PostAsync(text: "你才有病膩!");
                }
                else if (Regex.IsMatch(activity.Text, "智障"))
                {
                    await context.PostAsync(text: "你才智障膩!");
                }
                else if (Regex.IsMatch(activity.Text, "白痴"))
                {
                    await context.PostAsync(text: "你才白痴膩!");
                }
                else if (Regex.IsMatch(activity.Text, "白痴"))
                {
                    await context.PostAsync(text: "你才白痴膩!");
                }
            }
        }
    }
}