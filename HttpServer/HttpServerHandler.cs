using System;
using System.Text;
using DotNetty.Buffers;
using DotNetty.Codecs.Http;
using DotNetty.Common;
using DotNetty.Common.Utilities;
using DotNetty.Transport.Channels;
using System.Collections.Concurrent;
using TCSniffer.utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TCSniffer.HttpServer
{
    public class HttpServerHandler : SimpleChannelInboundHandler<IFullHttpRequest>
    {
        private static Form1 Frm => Form1.Form;
        static readonly ThreadLocalCache Cache = new ThreadLocalCache();
        sealed class ThreadLocalCache : FastThreadLocal<AsciiString>
        {
            protected override AsciiString GetInitialValue()
            {
                DateTime dateTime = DateTime.Now;
                return AsciiString.Cached($"{dateTime.DayOfWeek}, {dateTime:dd MMM yyyy HH:mm:ss z}");
            }
        }

        static readonly AsciiString TypePlain = AsciiString.Cached("text/plain");
        static readonly AsciiString ServerName = AsciiString.Cached("TC_QQSniffer Service");
        static readonly AsciiString ContentTypeEntity = HttpHeaderNames.ContentType;
        static readonly AsciiString DateEntity = HttpHeaderNames.Date;
        static readonly AsciiString ContentLengthEntity = HttpHeaderNames.ContentLength;
        static readonly AsciiString ServerEntity = HttpHeaderNames.Server;
        static readonly BlockingCollection<string> _keys = new BlockingCollection<string>();

        volatile ICharSequence Date = Cache.Value;

        void WriteResponse(IChannelHandlerContext ctx, IByteBuffer buf, ICharSequence contentType, ICharSequence contentLength)
        {
            var response = new DefaultFullHttpResponse(HttpVersion.Http11, HttpResponseStatus.OK, buf, false);
            HttpHeaders headers = response.Headers;
            headers.Set(ContentTypeEntity, contentType);
            headers.Set(ServerEntity, ServerName);
            headers.Set(DateEntity, Date);
            headers.Set(ContentLengthEntity, contentLength);
            ctx.WriteAsync(response);
        }

        public override void ExceptionCaught(IChannelHandlerContext context, Exception exception) => context.CloseAsync();

        public override void ChannelReadComplete(IChannelHandlerContext context) => context.Flush();

        protected override void ChannelRead0(IChannelHandlerContext ctx, IFullHttpRequest msg)
        {
            byte[] content = Encoding.UTF8.GetBytes("http server is ok");
            if (msg.Method == HttpMethod.Post)
            {

                string uri = msg.Uri.Replace("/?", "");
                string data = Unpooled.WrappedBuffer(msg.Content).
                    HexDump().DecodeHex().HexToString(Encoding.UTF8);
                HttpServerLog(msg.Method + ":" + uri + "\n" + data);
                foreach (string res in uri.Split('&'))
                {
                    string[] temp = res.Split('=');
                    if (temp.Length != 2) break;
                    if (temp[0] == "name" && (
                        temp[1] == "decryptKey" ||
                        temp[1] == "sessionKey" ||
                        temp[1] == "set_g_share_key"))
                    {
                        Frm.ThreadSafeUpdate(() => Frm.textBox_keys.Text +=
                        data.Replace("[", "").Replace("]","").Replace("\"","")
                        + "\r\n");
                    }

                }
                //JObject myJObject = (JObject)JsonConvert.DeserializeObject(data);

            }

            WriteResponse(ctx, Unpooled.WrappedBuffer(content),
                TypePlain,
                AsciiString.Cached(content.Length.ToString()));
        }

        public static void HttpServerLog(string text)
        {
            string output = string.Format("{0} {1}{2}\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), text, Environment.NewLine);
            Frm.ThreadSafeUpdate(() => Frm.richTextBox_httpserver_log.AppendText(output));
        }

    }
}
