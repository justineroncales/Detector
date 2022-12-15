using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Detector.Models
{
    public class Locations
    {
        public string Id { get; set; }
        public string Place { get; set; }
        public string Status { get; set; }


        static public async Task<List<Locations>> GetLocationsAsync()
        {
            var loc = new List<Locations>();
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync("http://ibqrattendance.somee.com/QRCode/GetDriverInfos");
                if (result.IsSuccessStatusCode)
                {
                    string res = await result.Content.ReadAsStringAsync();
                    loc = JsonConvert.DeserializeObject<List<Locations>>(res);
                }
            }
            return loc;
        }
    }
}
