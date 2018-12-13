using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Sockets;
using System;

public class SocketSpcripts : MonoBehaviour {
    public InputField hostInput;
    public InputField portInput;
    public Text connecttext;
    public Text textstr;
    public string serverstr;
    public InputField TextInput;
    Socket socket;
    const int buff_size = 1024;
    public byte[] readbuff = new byte[buff_size];

 

    private void Update()
    {
        textstr.text = serverstr;
    }
    public void Connection()
    {
        textstr.text = "";
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string host = hostInput.text;
        int port = int.Parse( portInput.text);
        socket.Connect(host, port);
        connecttext.text = socket.LocalEndPoint.ToString();
        socket.BeginReceive(readbuff, 0, buff_size, SocketFlags.None, ReceiveCb, null);
    }

    private void ReceiveCb(IAsyncResult ar)
    {
        try
        {
            int count = socket.EndReceive(ar);
            string str = System.Text.Encoding.Default.GetString(readbuff, 0, count);
            if (serverstr.Length > 300)
                serverstr = "";
            serverstr += str + "\n";
            socket.BeginReceive(readbuff, 0, buff_size, SocketFlags.None, ReceiveCb, null);
        }
        catch (Exception e)
        {
            textstr.text = "链接已断开"+e.Message;
            socket.Close();
        }
    }
    public void Send()
    {
        string str = TextInput.text;
        byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
        try
        {
            socket.Send(bytes);
        }
        catch (Exception e)
        {
            textstr.text = e.Message;
        }
    }
}
