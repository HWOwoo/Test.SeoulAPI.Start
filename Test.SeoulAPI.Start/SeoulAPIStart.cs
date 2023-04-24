using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.SeoulAPI;


namespace Test.SeoulAPI.Start
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("측정일자 yyyymmdd 입력");
                return;
            }

            string date = args[0];
            var apiStart = new SeoulAPIJson();
            apiStart.ReadJsonData(date);

        }
    }
}
