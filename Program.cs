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

            Console.WriteLine("{1}:{0}",valueSByte,valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueByte, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valudShort, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueUShort, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueInt, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueUInt, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueLong, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueULong, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueFloat, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueDouble, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueChar, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueString, valueSByte.GetType().Name);
            Console.WriteLine("{1}:{0}", valueBool, valueSByte.GetType().Name);

        }
    }
}
