using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte valueSByte = -100;
            byte valueByte = 100;
            short valudShort = -20000;
            ushort valueUShort = 50000;
            int valueInt = -1000000000;
            uint valueUInt = 4000000000;
            long valueLong = -800000000000;
            ulong valueULong = 9000000000000000000;

            float valueFloat=3.1415F;
            double valueDouble = 3.1415926535;

            char valueChar = 'A';
            string valueString = "C# PROGRAM";

            bool valueBool = true;

            Console.WriteLine("sbyte:{0}",valueSByte);
            Console.WriteLine("byte:{0}",valueByte);
            Console.WriteLine("short:", valudShort);
            Console.WriteLine("ushort:", valueUShort);
            Console.WriteLine("int:", valueInt);
            Console.WriteLine("uint:", valueUInt);
            Console.WriteLine("long:", valueLong);
            Console.WriteLine("ulong:", valueULong);
            Console.WriteLine("flong:", valueFloat);
            Console.WriteLine("double:", valueDouble);
            Console.WriteLine("char:", valueChar);
            Console.WriteLine("string:", valueString);
            Console.WriteLine("bool:", valueBool);

        }
    }
}
