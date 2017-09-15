using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/** 11. Pass by Reference  */
// - 메서드에 파라미터를 전달할 때, 만약 레퍼런스(참조)로 전달하고자 한다면 C# 키워드 ref를 사용한다. 
// - ref를 사용할 경우 메서드 내에서 변경된 값은 리턴 후에도 유효하다. 
// - ref를 사용하기 위해서는 ref로 전달되는 변수가 사전에 초기화되어져야 한다.

// - C#의 ref와 비슷한 기능을 하는 것으로 C# out 키워드가 있다. 
// - out을 사용하는 파라미터는 메서드 내에서 그 값을 반드시 지정하여 전달하게 되어 있다. 
// - C#의 ref는 해당 변수가 사전에 초기화되어야 하지만, C# out은 사전에 변수를 초기화할 필요는 없다. 

namespace St01_IntroEx04
{
    class Program
    {

        // ref 정의
        static double GetData(ref int a, ref double b)
        { return ++a * ++b; }

        // out 정의
        static bool GetData(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }

        static void Main(string[] args)
        {
            // ref 사용. 초기화 필요.
            int x = 1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(ret);

            // out 사용. 초기화 불필요.
            int c, d;
            bool bret = GetData(10, 20, out c, out d);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(bret);
        }
    }
}
