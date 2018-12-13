using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace lianxi
{
    class server
    {
        public Socket listedfd;
        public Conn[] conns;
        public int maxConn = 50;
        public int NewIndex()
        {
            if (conns == null)
            {
                return -1;
            }
            for(int i = 0; i < conns.Length; i++)
            {
                if (conns[i] == null)
                {
                    conns[i] = new Conn();
                    return i;
                }
                else if (conns[i].isUse == false)
                    return i;
            }
            return -1;
        }
        public void Start(string host,int port)
        {
            conns = new Conn[maxConn];
            for (int i = 0; i < maxConn; i++)
            {
                conns[i] = new Conn();
            }
            listedfd = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipadr = IPAddress.Parse(host);
            IPEndPoint ipep = new IPEndPoint(ipadr, port);
            listedfd.Bind(ipep);
            listedfd.Listen(maxConn);
            listedfd.BeginAccept(AcceptCB, null);
            Console.WriteLine("服务器启动");


        }

        private void AcceptCB(IAsyncResult ar)
        {
            try
            {
                Socket socket = listedfd.EndAccept(ar);
                int index = NewIndex();
                if (index < 0)
                {
                    socket.Close();
                    Console.WriteLine("链接已满");
                }
                else
                {
                    Conn conn = conns[index];
                    conn.Init(socket);
                    string adr = conn.GetAddress();
                    Console.WriteLine("kehuduanlianjie" + adr + "id =" + index);
                    conn.sock.BeginReceive(conn.readbuff, conn.buffCount, conn.BuffRemain(), SocketFlags.None, ReceiveCB, conn);
                    listedfd.BeginAccept(AcceptCB, null);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine("callback fail" + e);
            }
        }

        private void ReceiveCB(IAsyncResult ar)
        {
            Conn conn = (Conn)ar.AsyncState;

            try
            {
                int count = conn.sock.EndReceive(ar);
                if (count <= 0)
                {
                    Console.WriteLine(conn.GetAddress() + "与服务器断开链接");
                    conn.Close();
                    return;
                }
                string str = System.Text.Encoding.Default.GetString(conn.readbuff);
                Console.WriteLine("get" + conn.GetAddress() + " message=" + str);
                str = conn.GetAddress() + ":" + str;
                byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
                for (int i = 0; i < conns.Length; i++)
                {
                    if (conns[i] == null)
                        continue;
                    if (!conns[i].isUse)
                        continue;
                    Console.WriteLine("fuwuqifaxingxi gei" + conns[i].GetAddress());
                    conns[i].sock.Send(bytes);
                }
                conn.sock.BeginReceive(conn.readbuff, conn.buffCount, conn.BuffRemain(), SocketFlags.None, ReceiveCB, conn);

            }
            catch (Exception e)
            {

                Console.Write("get " + conn.GetAddress() + "duan kai lianjie "+e);
                conn.Close();
            }


        }
    }
}
