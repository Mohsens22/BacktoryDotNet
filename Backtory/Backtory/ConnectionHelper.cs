using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Backtory
{
    public class ConnectionHelper
    {
        public static async Task Initialize(string AuthID, string AuthMasterKey, string username, string password, string storageID)
        {
            var httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();
            form.Add(new StringContent(username), "username");
            form.Add(new StringContent(password), "password");

            httpClient.DefaultRequestHeaders.Add("X-Backtory-Authentication-Id", AuthID);
            httpClient.DefaultRequestHeaders.Add("X-Backtory-Authentication-Key", AuthMasterKey);
            HttpResponseMessage response = await httpClient.PostAsync("https://api.backtory.com/auth/login", form);

            string result = response.Content.ReadAsStringAsync().Result;
        }
    }
}
