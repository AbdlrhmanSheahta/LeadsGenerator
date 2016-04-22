using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leads_Generator
{
    public static class Extensions
    {
        public static string ArrayToString(this string[] x) {
            StringBuilder output = new StringBuilder();
            foreach (string item in x)
            {
                output.Append(item + "\r\n");
            }
            return output.ToString().TrimEnd("\r\n".ToCharArray());
        }
        public static string Quote(this string x,string quote_with) {
            return quote_with + x + quote_with;
        }
        public static string Quote(this string x)
        {
            return "`" + x + "`";
        }
        public static string SiwtchDateFormat(this string x) {
            string[] splitted = x.Split('/');
            string new_date = splitted[1] + "/" + splitted[0] + "/" + splitted[2];
            return new_date;
        }
        public static Type ToType(this string x)
        {
            Type toreturn = typeof(string);
            if (typeof(bool).ToString() == x)
            {
                toreturn = typeof(bool);
            }
            else if (typeof(Int32).ToString() == x)
            {
                toreturn = typeof(Int32);
            }
            //else if (typeof(DateTime).ToString() == x)
            //{
            //    toreturn = typeof(DateTime);
            //}
            return toreturn;
        }

        public static DateTime AmericanDate(this string input)
        {
            char separator = (input.Contains('\\')) ? '\\' : '/';
            string[] sections = input.Split(separator);
            try
            {
                DateTime to_return = new DateTime(int.Parse(sections[2]), int.Parse(sections[0]), int.Parse(sections[1]));
                return to_return;
            }
            catch (Exception)
            {
                return new DateTime(1, 1, 1);
            }
        }

        public static Color ToColor(this string x) { 
            string[] rgb= x.Split(',');
            int a = int.Parse(rgb[0]);
            int r = int.Parse(rgb[1]);
            int g = int.Parse(rgb[2]);
            int b = int.Parse(rgb[3]);
            return Color.FromArgb(a,r,g,b);
        } 
    }
}
