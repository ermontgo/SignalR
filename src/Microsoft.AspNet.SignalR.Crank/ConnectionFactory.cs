using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;

namespace Microsoft.AspNet.SignalR.Crank
{
	public interface IConnectionFactory
	{
		Connection CreateConnection(string url);
	}
	
	public class ConnectionFactory : IConnectionFactory
	{
		public Connection CreateConnection(string url)
		{
			return new Connection(url);
		}
	}
}
