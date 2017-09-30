using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientForMohsen
{
    class Secret
    {
        public static void Init()
        {
            Backtory.ConnectionHelper.Initialize("59c38e9fe4b05384c5cd7028", "6e7e05ef81dd4c3b9991f19f", "mohsens2@outlook.com", "@@90905050-adtxxX", "59c38f08e4b055bfe7214da3").Wait();
        }
    }
}
