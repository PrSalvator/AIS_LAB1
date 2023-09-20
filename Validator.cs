using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB1
{
    class Validator
    {
        static public bool Is_Letter(string target)
        {
            if (int.TryParse(target, out var a))
            {
                return true;
            }
            return false;
        }
        static public bool In_Interval(int start, int finish, int target)
        {
            if(target < start || target > finish)
            {
                return false;
            }

            return true;
        }
    }
}
