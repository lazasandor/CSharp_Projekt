using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApi_Common.Models;

namespace WebApi_Client_Jobs.DataProviders
{
    class DataProvider
    {
        private const string url = "http://localhost:5000/api/job";

        public static IEnumerable<Job> GetJobs()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawData = response.Content.ReadAsStringAsync().Result;
                    var jobs = JsonConvert.DeserializeObject<IEnumerable<Job>>(rawData);
                    return jobs;
                }
                throw new InvalidOperationException(response.StatusCode.ToString());
            }
            
        }

        public static void CreateJob(Job job)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(job);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdateJob(Job job)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(job);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PutAsync(url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void DeleteJob(long id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync($"{url}/{id}").Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}
