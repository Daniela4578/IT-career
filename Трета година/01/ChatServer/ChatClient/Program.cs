using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port:11000);

            Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sender.Connect(remoteEP);
                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                while (true)
                {
                    Console.WriteLine(">");
                    string message = Console.ReadLine();
                    byte[] mgs = Encoding.ASCII.GetBytes(s: message + "<EOF>");
                    int byteSent = sender.Send(mgs);

                    if (message == "exit")
                        break; 
                }

                sender.Shutdown(how: SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}