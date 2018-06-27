using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0)
            {
                return "0";
            }

            StringBuilder sb = new StringBuilder();

            //考慮負數
            sb.Append((numerator >= 0) ^ (denominator >= 0) ? "-" : string.Empty);

            //只取正數
            var _numerator =Math.Abs(Convert.ToInt64(numerator));
            var _denominator = Math.Abs(Convert.ToInt64(denominator));
            sb.Append(_numerator / _denominator);

            //餘數
            var Remainder = (_numerator % _denominator);
            if (Remainder == 0)
            {
                return sb.ToString();
            }

            sb.Append(".");
            var Map = new Dictionary<Int64, int>();
            Map.Add(Remainder, sb.Length);
            while (Remainder != 0)
            {
                sb.Append((Remainder *10) / _denominator);
                Remainder = (Remainder * 10) % _denominator;
                if (Map.ContainsKey(Remainder))
                {
                    var Index = Map[Remainder];
                    //開始重複
                    sb.Insert(Index, "(");
                    sb.Append(")");
                    break;
                }

                Map.Add(Remainder, sb.Length);
            }

            return sb.ToString();
        }
    }
}
