using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Helper
{
    // Intermediate class to connect the API
    public class ApiConnector
    {

        private string url { get; set; }


        public ApiConnector()
        {
            url = "https://localhost:41405/api/";
        }

        public ApiConnector(string _url)
        {
            url = _url;
        }

        //GET
        public string Get(string action)
        {
            string response = "";
            try
            {
                var wb = WebRequest.Create(url + action);
                Debug.Print(url + action);
                if (wb != null)
                {
                    wb.Method = "GET";
                    wb.Timeout = 1200;
                    wb.ContentType = "application/json";

                    using (Stream s = wb.GetResponse().GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(s))
                        {
                            response = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return response;
        }

        //GET ID - Confirmar se é necessario?
        public string GetId(string action, int id)
        {
            string response = "";
            try
            {
                var wb = WebRequest.Create(url + action + id);

                if (wb != null)
                {
                    wb.Method = "GET";
                    wb.Timeout = 1200;
                    wb.ContentType = "application/json";
                   

                    using (Stream s = wb.GetResponse().GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(s))
                        {
                            response = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return response;
        }

        public string Post(string action, string data)
        {
            string result = "";
            try
            {
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpClient hc = new HttpClient();
                HttpResponseMessage rp = hc.PostAsync(url + action, content).GetAwaiter().GetResult();
                result = rp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return result;
        }
    }
}
