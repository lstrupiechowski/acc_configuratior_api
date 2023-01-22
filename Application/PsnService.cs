using Application.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Application
{
    public class PsnService : IPsnService
    {
        public string GetPsnId(string psn)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://psn.flipscreen.games/search.php?username=" + psn);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            string result = null;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            var user = JsonConvert.DeserializeObject<UserData>(result);
            return user.user_id;
        }
    }
}