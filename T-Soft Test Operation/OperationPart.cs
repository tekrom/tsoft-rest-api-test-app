using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace TSoftRestApiTestApp
{
    internal class OperationPart
    {
        public static string _Url = "";
        static string _User = "";
        static string _Pass = "";

        public bool AccessControl(string url, string user, string pass)
        {
            bool check;

            _Url = url;
            _User = user;
            _Pass = pass;

            if (getToken() != "")
            {
                check = true;
            }
            else
            {
                check = false;
            }

            return check;
        }

        public string getToken()
        {
            string token = "";

            WebClient wc = new WebClient();

            NameValueCollection col = new NameValueCollection();

            col.Add("pass", _Pass);
            byte[] pageBinary = wc.UploadValues(_Url + "/rest1/auth/login/" + _User, col);
            string page = System.Text.Encoding.UTF8.GetString(pageBinary);
            Dictionary<string, object> deserializePage = JsonConvert.DeserializeObject<Dictionary<string, object>>(page);

            if (deserializePage["success"].ToString() == "True")
            {
                var x = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(deserializePage["data"].ToString());

                token = x[0]["token"].ToString();

            }

            return token;
        }


        public Tuple<string, string, List<Parameters>> getData(string methotName, Dictionary<string, string> Param, string token, string urlParam)
        {
            string message = "";
            var retValParamList = new List<Parameters>();

            WebClient wc = new WebClient();

            //retValParamList.Add(new Parameters()
            //{
            //    Key = "token",
            //    Value = token
            //});

            foreach (var prm in Param)
            {
                retValParamList.Add(new Parameters()
                {
                    Key = prm.Key,
                    Value = prm.Value
                });
            }
            Param.Add("token", token);
            var collection = Param.Aggregate(new NameValueCollection(),
                 (seed, current) =>
                 {
                     seed.Add(current.Key, current.Value);
                     return seed;
                 });



            byte[] pageBinary;

            if (string.IsNullOrEmpty(urlParam))
            {
                pageBinary = wc.UploadValues(_Url + "/rest1/" + methotName, collection);
            }
            else
            {
                pageBinary = wc.UploadValues(_Url + "/rest1/" + methotName + "/" + urlParam, collection);
            }


            string page = System.Text.Encoding.UTF8.GetString(pageBinary);

            Dictionary<string, object> deserializePage = JsonConvert.DeserializeObject<Dictionary<string, object>>(page);

            if (deserializePage["success"].ToString() == "True" && deserializePage["data"] != null)
            {
                page = JsonConvert.DeserializeObject(deserializePage["data"].ToString()).ToString();
            }
            else
            {
                page = "[{}]";
            }

            message = JsonConvert.DeserializeObject(deserializePage["message"].ToString()).ToString();

            return new Tuple<string, string, List<Parameters>>(page, message, retValParamList);
        }


        public Tuple<string, string, Dictionary<string, string>> setData(string methotName, string Data, Dictionary<string, string> Param, string token, string urlParam)
        {
            string message = "";

            WebClient wc = new WebClient();

            NameValueCollection col = new NameValueCollection();

            col.Add("token", token);
            col.Add("data", Data);

            if (Param.Count > 0)
            {
                foreach (var prm in Param)
                {
                    col.Add(prm.Key.ToString(), prm.Value.ToString());
                }
            }

            byte[] pageBinary;

            if (string.IsNullOrEmpty(urlParam))
            {
                pageBinary = wc.UploadValues(_Url + "/rest1/" + methotName, col);
            }
            else
            {
                pageBinary = wc.UploadValues(_Url + "/rest1/" + methotName + "/" + urlParam, col);
            }

            string page = System.Text.Encoding.UTF8.GetString(pageBinary);

            Dictionary<string, object> deserializePage = JsonConvert.DeserializeObject<Dictionary<string, object>>(page);

            message = JsonConvert.DeserializeObject(deserializePage["message"].ToString()).ToString();

            return new Tuple<string, string, Dictionary<string, string>>(page, message, Param);
        }

        public Tuple<string, string, Dictionary<string, string>> setData(string methotName, string Data, Dictionary<string, string> Param, string token, string urlParam, string imagePath, string imageName)
        {
            string message = "";

            NameValueCollection col = new NameValueCollection();

            Dictionary<string, object> dict = new Dictionary<string, object>();

            dict.Add("token", token);


            // col.Add("token", token);

            if (Param.Count > 0)
            {
                foreach (var prm in Param)
                {
                    dict.Add(prm.Key.ToString(), prm.Value);
                    // col.Add(prm.Key.ToString(), prm.Value.ToString());
                }
            }

            string response;

            if (string.IsNullOrEmpty(urlParam))
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    response = HttpUtility.UrlDecode(PostFile(_Url + "/rest1/" + methotName, dict,
                        buffer, imageName));
                }
            }
            else
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    response = HttpUtility.UrlDecode(PostFile(_Url + "/rest1/" + methotName + "/" + urlParam, dict,
                        buffer, imageName));
                }
            }


            Dictionary<string, object> deserializePage = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);

            message = JsonConvert.DeserializeObject(deserializePage["message"].ToString()).ToString();

            return new Tuple<string, string, Dictionary<string, string>>(response, message, Param);
        }


        private string PostFile(string URL, Dictionary<string, object> PostData, byte[] file, string fileName)
        {
            //Logger.LogMessage("PostFile kısmına gelindi");
            //Router.IoC.GetLogger("Sqlite Log").LogMessage(URL);
            HttpWebRequest request = WebRequest.Create(URL) as HttpWebRequest;
            Encoding e = Encoding.UTF8;

            string userAgent = "Someone";

            string formDataBoundary = "-----------------------------289477580292999";
            string contentType = "multipart/form-data; boundary=" + formDataBoundary;
            Stream formDataStream = new System.IO.MemoryStream();
            string postData = "";
            foreach (KeyValuePair<string, object> o in PostData)
            {
                postData += string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n",
                                                formDataBoundary,
                                                o.Key,
                                                o.Value);

            }

            formDataStream.Write(e.GetBytes(postData), 0, e.GetByteCount(postData));
            string header = string.Format(
                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\";\r\nContent-Type: {3}\r\n\r\n",
                formDataBoundary,
                "image",
                HttpUtility.UrlEncode(fileName),
                "image/jpeg");


            formDataStream.Write(e.GetBytes(header), 0, header.Length);
            formDataStream.Write(file, 0, file.Length);



            string footer = "\r\n--" + formDataBoundary + "--\r\n";
            formDataStream.Write(e.GetBytes(footer), 0, footer.Length);

            // Dump the Stream into a byte[]
            formDataStream.Position = 0;
            byte[] formData = new byte[formDataStream.Length];
            formDataStream.Read(formData, 0, formData.Length);
            formDataStream.Close();


            if (request == null)
            {
                throw new NullReferenceException("request is not a http request");
            }

            try
            {
                // Set up the request properties
                request.Method = "POST";
                request.ContentType = contentType;
                request.UserAgent = userAgent;
                request.CookieContainer = new CookieContainer();
                request.ContentLength = formData.Length; // We need to count how many bytes we're sending. 
                request.Timeout = -1;

                using (Stream requestStream = request.GetRequestStream())
                {
                    // Push it out there
                    requestStream.Write(formData, 0, formData.Length);
                    requestStream.Close();
                }

                string s = e.GetString(formData);
                string s2 = e.GetString(file);

                //LoggerAbstraction Logger = Router.IoC.GetLogger("Text Log");//todo düzelt


                //Logger.LogMessage(
                //    $"{string.Join(Environment.NewLine, PostData.Keys.Select(q => $"{q}=>{PostData[q]}"))} Formdatası Gönderilecek....");

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                string retVal = new StreamReader(response.GetResponseStream()).ReadToEnd();

                //Logger.LogMessage(
                //    $"{string.Join(Environment.NewLine, PostData.Keys.Select(q => $"{q}=>{PostData[q]}"))} Formdatası Yanıtı Geldi");
                //Logger.LogMessage("Servisten dönen yanıt :"+retVal);
                //var logger=Router.IoC.GetLogger("Text Log");
                //logger.LogMessage(retVal);
                return retVal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
}
