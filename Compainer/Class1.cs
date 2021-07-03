using System;
using System.IO;
using System.Drawing;
using System.Text;

namespace Compainer
{
    public class Class1
    {
        static string pass;
        public static string Decoded(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
                sb.Append((char)(input[i] ^ pass[(i % pass.Length)]));
            return sb.ToString();
        }
    }
}
