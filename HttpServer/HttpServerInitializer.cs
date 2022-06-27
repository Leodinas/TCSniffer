using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Codecs.Http;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
namespace TCSniffer.HttpServer
{
    public class HttpServerInitializer : ChannelInitializer<AbstractSocketChannel>
    {
        protected override void InitChannel(AbstractSocketChannel channel)
        {
            var pipeline = channel.Pipeline;
            pipeline.AddLast(new HttpServerCodec());
            pipeline.AddLast(new HttpObjectAggregator(65536));
            pipeline.AddLast(new HttpServerHandler());
        }
    }
}
