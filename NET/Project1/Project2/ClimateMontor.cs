using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project2
{
    class ClimateMontor
    {
        private ILogger logger;
        public ClimateMontor(ILogger logger)
        {
            this.logger = logger;
        }
        
        public void start()
        {
            while (true)
            {
                Write("온도 입력 : ");
                String temperature = ReadLine();
                if (temperature == "")
                    break;
                logger.WriteLog("현재 온도 :" + temperature);
            }
        }
    }
}
