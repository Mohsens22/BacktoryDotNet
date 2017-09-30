using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientForMohsen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Backtory.ConnectionHelper.Initialize("59c38e9fe4b05384c5cd7028", "6e7e05ef81dd4c3b9991f19f", "mohsens2@outlook.com", "@@90905050-adtxxX", "59c38f08e4b055bfe7214da3").Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

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
