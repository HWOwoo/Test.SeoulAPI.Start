using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SeoulAPI
{
    class SeoulAPI
    {
        static void Main(string[] args)
        {
        }

        public void ReadJson()
        {
            string inputKey = "5378624a4973757239367644476152";
            string inputArgs = ""; // 매개변수 yyyymmdd

            try
            {
                string apiURL = "http://openapi.seoul.go.kr:8088/" + inputKey + "/json/DailyAverageRoadside/1/100/" + args[0];
            }
            catch(Exception ex)
            {
                Console.WriteLine("오류발생");
            }
        }
    }
}
