using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace csharpRestClient
{


    public enum httpVerb
    {

        GET,
        POST,
        PUT,
        DELETE

    }

    public enum authenticationType
    {
        Basic,
        NTLM
    }

    public enum authenticationTechnique
    {
        RollYourOwn,
        NetworkCredential
    }

    class RestClient
    {

        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public authenticationType authType { get; set; }
        public authenticationTechnique authTech { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string postJSON { get; set; }


        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;

        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();


 

                NetworkCredential netCred = new NetworkCredential(userName, userPassword);
                request.Credentials = netCred;


            if(request.Method=="POST" && postJSON != string.Empty)
            {
                request.ContentType = "application/json";
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(postJSON);
                    swJSONPayload.Close();
                }

            }


            HttpWebResponse response = null;
                      
            try
            {

                response = (HttpWebResponse)request.GetResponse();

                
                using (System.IO.Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {

                            strResponseValue = reader.ReadToEnd();
                        }

                    }
                }
                
            }

            catch (Exception ex)
            {

                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";

            }

            finally
            {
                if(response!=null)
                {

                    ((IDisposable)response).Dispose();
                }

            }

                return strResponseValue;
        }

    }
}
