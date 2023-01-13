using System;
using System.Collections.Generic;
using System.Text;

namespace _13._01._23
{
    internal static class StringExtencion
    {
        public static string Reverse(this string a)
        {
            string reverse = " ";
            //char[] ch = a.ToCharArray();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                reverse += a[i];
            }

            return a;
        }
        
       
    }
}
