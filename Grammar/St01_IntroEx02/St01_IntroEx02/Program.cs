using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace St01_IntroEx02
{
    class Program
    {
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }

        static IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }

        static void Main(string[] args)
        {
            /** 6. enum */
            // - 열거형 상수를 표현하기 위한 것으로 이를 이용하면 상수 숫자들을 보다 의미있는 단어들로 표현할 수 있다.
            // - 각 요소는 별도의 지정이 없으면 첫번째 요소가 0, 두번째 요소가 2 등으로 1씩 증가된 값을 할당받는다.
            // - enum문은 클래스안이나 네임스페이스내에서만 선언될 수 있다.
            //   즉 메소드안이나 프로퍼티 안에서는 선언되지 않는다.
            
            /** 7. 연산자 */
            // - ??연산자 : C# 3.0 이상에서 지원하는 연산자이다.
            //   ??왼쪽 피연산자의 값이 NULL인 경우 ??뒤의 피연산자 값을 리턴하고, 아닌경우 왼쪽의 피연산자 값을 리턴한다.
            //   ??연산자는 왼쪽 피연산자가 NULL이 허용되는 데이터타입인 경우에만 사용된다.
            int? i = null;
            i = i ?? 0;

            /** 8. yield */
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }

        }

        /** 9. 네임스페이스 */
        // - 클래스들은 대게 네임스페이스안에 정의된다.
        // - 비록 클래스가 네임스페이스 없이도 정의 될 수 있지만, 거의 모든경우 네임스페이스안에 정의하는것이 일반적이다.
        // - 네임스페이스를 사용하기 위해서는 클래스명 앞에 네임스페이스명을 전부 적거나, 
        //   프로그램 맨 윗단에 'using'을 이용하여 사용하고자 하는 네임스페이스명을 한번 설정해주고 이후 해당파일 내에서 네임스페이스 선언없이 클래스에 바로 접근하는것이다.
        // - 다른 클래스에서 지금 이 네임스페이스를 사용하려면 이 dll을 참조로 추가하고 'using St01_IntroEx02;'을 파일 상단에 적어주면 된다.
        public int Calculate(int a, int b)
        {
            int absSum = System.Math.Abs(a) + Math.Abs(b);
            return absSum;
        }
    }
}
