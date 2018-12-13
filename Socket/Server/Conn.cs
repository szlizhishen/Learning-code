using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace lianxi
{
    class Conn
    {
        public const int buff_size = 1024;
        public Socket sock;
        public bool isUse = false;
        public byte[] readbuff = new byte[buff_size];
        public int buffCount = 0;
        public Conn()
        {
            readbuff = new byte[buff_size];
            
        }
        public void Init(Socket socket)
        {
            this.sock = socket;
            isUse = true;
            buffCount = 0;
        }
        public int BuffRemain()
        {
            return buff_size - buffCount;
        }
        public string GetAddress()
        {
            if (!isUse)
            {
                return "wufahuodedizhi";
            }
            return sock.RemoteEndPoint.ToString();
        }
        public void Close()
        {
            if (!isUse)
                return;
            Console.WriteLine(GetAddress() + "yufuwuqiduankailianjie");
            sock.Close();
            isUse = false;

        }

    }
}
