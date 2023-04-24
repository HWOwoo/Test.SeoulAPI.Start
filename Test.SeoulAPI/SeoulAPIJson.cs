using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SeoulAPI
{
    public class SeoulAPIJson
    {
        string inputKey = "5378624a4973757239367644476152";
        string inputUrl = "http://openapi.seoul.go.kr:8088/{0}/json/DailyAverageRoadside/1/100/{1}";

        public void ReadJsonData(string data)
        {
            string url = string.Format(inputUrl, inputKey, data);
        }
    }
}
