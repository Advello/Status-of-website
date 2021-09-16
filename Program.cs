using System;
using System.IO;
using System.Net;

namespace webreq
{
    public class Webreq {
        public void webrequest(string website1) {	
            WebRequest request = WebRequest.Create (website1);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine (response.StatusDescription);
            Stream dataStream = response.GetResponseStream ();
            StreamReader reader = new StreamReader (dataStream);
            string responseFromServer = reader.ReadToEnd ();
            Console.WriteLine (responseFromServer);
            reader.Close ();
            dataStream.Close ();
            response.Close ();
        }
    }
    public class WebRequestGetExample
    {
        
        public static void Main()
        {
            string website = Console.ReadLine();
            Webreq c = new Webreq();
            c.webrequest(website);
        }
    }
}