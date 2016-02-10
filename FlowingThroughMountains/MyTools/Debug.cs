using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace FlowingThroughMountains.MyTools
{
    public class Debug : System.IO.TextWriter
    {
        public static void Write(char[] buffer, int index, int count)
        {
            System.Diagnostics.Debug.Write(new String(buffer, index, count));
        }

        public static void Write(string value)
        {
            System.Diagnostics.Debug.Write(value);
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.Default; }
        }
    }
}