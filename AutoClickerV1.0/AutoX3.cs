using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace AutoClickerV1._0
{
    class AutoX3
    {
        AutoItX3 auto = new AutoItX3();

        public void Click(string DurumSec, int x, int y, int manyClick, int speed)
        {
            auto.MouseClick(DurumSec, x, y, manyClick, speed);
        }

    }
}
