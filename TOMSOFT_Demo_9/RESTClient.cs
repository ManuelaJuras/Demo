using System;
using System.IO;            //Needs to be added
using System.Net;           //Needs to be added
using System.Text;          //Needs to be added

namespace restClient
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RESTClient
    {
        public string endPoint { get; set; }
        public string paramNaziv { get; set; }
        public string paramPJID { get; set; }
        public string paramDatumOd { get; set; }
        public string paramDatumDo { get; set; }
        public httpVerb httpMethod { get; set; }
        public string ContentType { get; set; }

        public string paramKorisnickoIme { get; set; }
        public string paramZaporka { get; set; }
        public string rootServiceURL { get; set; }

        public int endpointURLnumber { get; set; }

        // Default Constructor

        public RESTClient()
        {
            endPoint = "";

            paramNaziv = "";
            paramPJID = "";
            paramDatumOd = "";
            paramDatumDo = "";

            httpMethod = httpVerb.GET;
            ContentType = "text/xml";

            paramKorisnickoIme = "<unesi korisničko ime>";
            paramZaporka = "<unsei zaporku>";

            rootServiceURL = "http://apidemo.luceed.hr/datasnap/rest/";
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            switch (endpointURLnumber)
            {
                case 0:
                    if (!string.IsNullOrWhiteSpace(paramNaziv))
                        endPoint = rootServiceURL + "artikli/naziv/" + paramNaziv + "";
                    else
                        endPoint = rootServiceURL + "artikli/naziv/";
                    break;
                case 1:
                        endPoint = rootServiceURL + "mpobracun/placanja/" + paramPJID + "/" + paramDatumOd + "/" + paramDatumDo + "";
                    break;
                case 2:
                        endPoint = rootServiceURL + "mpobracun/artikli/" + paramPJID + "/" + paramDatumOd + "/" + paramDatumDo + "";
                    break;
            }

            var request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();
            request.Credentials = new NetworkCredential(paramKorisnickoIme, paramZaporka);
            request.ContentLength = 0;
            request.ContentType = ContentType;

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
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
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }
    }
}
