using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CelebAppClient
{
    public static class CelebApi
    {
        const string API_URL = "http://localhost:56181/api/Celeb";
        private static Dictionary<int, CelebrityItem> GetCeleb(string command)
        {
            using (var client = new WebClient())
            {
                var responseString = client.DownloadString($"{API_URL}/{command}");
                var result = JsonConvert.DeserializeObject<Dictionary<int, CelebrityItem>>(responseString);
                return result;
            }
        }

        public static Dictionary<int, CelebrityItem> RestartDatabaseFromWebApi()
        {
            return GetCeleb("RestoreAll");
        }

        public static Dictionary<int, CelebrityItem> LoadFromApi(bool restoreAll = false)
        {
            return GetCeleb(restoreAll ? "LoadOriginal" : "LoadFromLocal");
        }

        public static int DeleteCeleb(CelebrityItem celebrityItem)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data.Add("CelebrityId", celebrityItem.Id.ToString());
                wb.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                Uri uri = new Uri($"{API_URL}/Delete");
                var response = wb.UploadValues(uri, "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
                return Convert.ToInt32(responseInString); // return the id of succeded delete id
            }
        }
    }
}
