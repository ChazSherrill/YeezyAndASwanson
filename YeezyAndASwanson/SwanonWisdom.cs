using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace YeezyAndASwanson
{
    public class SwanonWisdom
    {
        public SwanonWisdom()
        {
        }

        public static string SwansonSpeaks()
        {
        var SwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

        var client = new HttpClient();

        var SwansonResponse = client.GetStringAsync(SwansonURL).Result;

        var SwansonQuote = JArray.Parse(SwansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

        return $"Swanson Speaketh {SwansonQuote}";
        }
    }
}
