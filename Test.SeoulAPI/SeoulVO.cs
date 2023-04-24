using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SeoulAPI
{
    public class SeoulVO
    {
        private string message;
        private string msrdtDe;
        private string msrclsCd;
        private string msrstenm;
        private int pm10;
        private double o3;
        private double no2;
        private double co;
        private double so2;

        public string MESSAGE { get { return message; } }
        public string MSRT_DE { get { return msrdtDe; } }
        public string MSRCLS_CD { get { return msrclsCd; } }
        public string MSRSTE_NM { get { return msrstenm; } }
        public int PM10 { get { return pm10; } }
        public double O3 { get { return o3; } }
        public double NO2 { get { return no2; } }
        public double CO { get { return co; } }
        public double SO2 { get { return so2; } }


    }
}
