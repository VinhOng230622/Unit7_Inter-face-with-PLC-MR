//back end & server side

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GPUN_1
{
   public class WebServer
    {
        private HttpListener listener;
        private PLCController plc;
    
    public WebServer(PLCController plcController)
    {
            plc = plcController;
    }
        public void Start()
        {
            Task.Run(() =>
            {
                try
                {
                    listener = new HttpListener();
                    listener.Prefixes.Add("http://*:8080/"); // lắng nghe tất cả IP ở port 8080
                    listener.Start();

                    Console.WriteLine("WebServer đang chạy tại http://localhost:8080/");

                    while (true)
                    {
                        var context = listener.GetContext();
                        ProcessRequest(context);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi WebServer: " + ex.Message);
                }
            });
        }

        private void ProcessRequest(HttpListenerContext context)
        {
            string responseString = "";

            try
            {
                string path = context.Request.Url.AbsolutePath.ToLower();

                if (path == "/turn_on")
                {
                    plc.WriteCoil(1, 0, true);
                    responseString = "Đã bật coil 0";
                }
                else if (path == "/turn_off")
                {
                    plc.WriteCoil(1, 0, false);
                    responseString = "Đã tắt coil 0";
                }
                else if (path == "/read")
                {
                    var values = plc.ReadHoldingRegisters(1, 0, 1);
                    responseString = $"Giá trị: {values[0]}";
                }
                else
                {
                    responseString = "Sai endpoint. Hãy thử /turn_on, /turn_off, hoặc /read";
                }
            }
            catch (Exception ex)
            {
                responseString = "Lỗi: " + ex.Message;
            }

            byte[] buffer = Encoding.UTF8.GetBytes(responseString);
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.OutputStream.Close();
        }
    }
}
