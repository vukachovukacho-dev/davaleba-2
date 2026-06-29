using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_10
{
    internal class Helper
    {
        public static void PrintByCountry(Employ[] employs, Country country)
        {
            foreach (Employ emp in employs)
            {
                if (emp.Country == country)
                {
                    emp.PrintInfo();
                }
            }
        }
    }
}
