using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace St01_IntroEx03
{
    class Program
    {

        // 구조체 정의
        struct MyPoint
        {
            public int X;
            public int Y;

            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", X, Y);
            }
        }

        static void Main(string[] args)
        {
            
            /** - Value Type VS Reference Type */
            // - C#은 value type과 reference type을 지원한다.
            // - 구조체(struct)를 사용하면 value type을 만들고, 클래스(class)를 사용하면 reference type을 만든다.
            // - C# .NET의 기본 데이터형들은 struct로 정의되어 있다. 즉 int, double, float, book등의 기본 데이터 타입은 모두 구조체로 정의된 value type이다.
            // - value type은 상속될 수 없으며, 주로 상대적으로 간략한 데이터값을 저장하는데 사용된다.
            // - Reference Type은 클래스를 정의하여 만들기때문에 상속이 가능하고, 좀 더 복잡한 데이터와 행위들을 정의하는 곳이 많이 사용된다.
            // - Value type의 파라메터 전달은 데이터를 복사(copy)하여 전달하는 반면, Reference type은 Heap상의 객체에 대한 레퍼런스(reference)를 전달하여 이루어진다.

            /* 10. 구조체 */
            // - 구조체는 클래스와 같이 메소드, 프로퍼티 등 거의 비슷한 구조를 가지고 있지만, 상속은 할 수 없다.
            // - 하지만 클래스와 마찬가지로 인터페이스(interface)를 구현할 수는 있다.
            // 구조체 사용
            MyPoint pt = new MyPoint(10, 12);
            Console.WriteLine(pt.ToString());

        }
    }
}
