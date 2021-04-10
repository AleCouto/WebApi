using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Helper
{
    // Intermediate class to connect the API
    public class ApiConnector
    {

        private string url { get; set; }
       

        public ApiConnector()
        {
            url = "https://localhost:41405/";
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
                if(wb != null)
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
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return response;
        }
    }
}
