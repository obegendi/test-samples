using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Practices
{
    public class AnalyticsServices
    {
        public async Task<string> GetSessions()
        {
            string baseUrl = "https://analytics.google.com";

            using (HttpClient client = new HttpClient())

            //Setting up the response...         

            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    //Database logic
                    //dateTimeProvider.DayOfWeek() 
                    if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
                    {
                        AddToData(data);
                    }
                    else
                    {
                        Console.WriteLine("Not Today!");
                    }
                    return data;
                }
            }
            return "";
        }

        public bool AddToData(string data)
        {
            //Parsing

            return true;
        }
    }
}
