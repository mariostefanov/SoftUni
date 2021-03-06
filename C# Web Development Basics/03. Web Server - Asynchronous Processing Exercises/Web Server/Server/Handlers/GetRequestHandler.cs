using System;
using System.Collections.Generic;
using System.Text;
using WebServer.Server.HTTP.Contracts;

namespace WebServer.Server.Handlers
{
    public class GetRequestHandler : RequestHandler
    {
        public GetRequestHandler(Func<IHttpContext, IHttpResponse> func) 
            : base(func)
        {
        }
    }
}
