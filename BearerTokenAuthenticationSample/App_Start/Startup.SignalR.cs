using Common.Connections;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BearerTokenAuthenticationSample
{
	public partial class Startup
	{
		public void ConfigureSignalR(IAppBuilder app)
        {
            app.MapConnection<AuthorizeEchoConnection>("/echo");
            app.MapSignalR();
        }
	}
}