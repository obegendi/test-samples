using Newtonsoft.Json;
using Practices.Models;
using System.Net.Http;

namespace Practices.IntegrationServices
{
    public class UberQualityService
    {
        public async bool ValidateCustomer()
        {
            string baseUrl = "https://uberquality.hesapkurdu.com";

            using (HttpClient client = new HttpClient())

            //Setting up the response...         

            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    var customer = JsonConvert.DeserializeObject<Customer>(data);
                    if(customer != null)
                    {
                        //Database save logic
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}