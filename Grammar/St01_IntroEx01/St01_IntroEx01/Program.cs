using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace St01_IntroEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            /** 1. 콘솔 메시지 출력 */
            System.Console.WriteLine("Hello World!");

            /** 2. 데이터 타입 */
            // Bool
            bool boolean01 = true;

            // Numeric
            short showNum01 = -32768;
            int intNum01 = 2147483647;
            long longNum01 = 1234L;      // L suffix
            float floatNum01 = 123.45F;   // F suffix
            double double01 = 123.45;
            double double02 = 123.45D; // D suffix
            decimal decimal01 = 123.45M; // M suffix

            // Char/String
            char char01 = 'A';
            string string01 = "Hello";

            // DateTime  2011-10-30 12:35
            DateTime dateTime01 = new DateTime(2011, 10, 30, 12, 35, 0);

            //데이터 타입의 최대값, 최소값 출력
            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            /** 3. NULL */
            // - 정수(int)나 날짜(DateTime)와 같은 Value Type은 일반적으로 NULL을 가질 수 없다.
            // - C# 2.0버전부터 이러한 타입들에 대해 NULL을 가질 수 있게 했는데, 이를 'Nullable Type'이라고 부른다.
            // - int 또는 DateTimme타입명 뒤에 '?'를 붙이면 'Nullable Type'이 된다.
            // - 'Nullable Type'을 일반 Value Type에 넣으려면 '.Value'속성을 사용해야 한다.
            String string02;
            string02 = null;
            int? intNum02 = null;
            intNum02 = 100;
            Nullable<int> intNum03 = null;
            intNum03 = 10;
            int intNum04 = intNum03.Value;

            /** 3. 변수 */
            // - 로컬변수(지역변수)는 기본값을 할당받지 못하기 때문에 반드시 사용전에 값을 할당해야 하는 반면,
            //   필드(전역변수)는 값을 할당하지 않으면 기본값이 자동으로 할당된다. 
            // - 예를 들어 int타입의 전역변수는 선언 후 초기화하지 않으면 0이 할당된다.
            // - 모든 C#변수는 대소문자를 구별한다.
            int intNum05 = 10; //전역변수
            const int INTNUM08 = 50;

            /** 4. 배열 */
            // - C#배열은 최고32차 배열을 가질 수 있다.
            // - 다차원 배열에서 각 차원별 배열 요소크기가 동일한 'Rectangular'배열은 [ , ]형태로 나타낸다
            // - 가변배열의 경우 [][]와 같이 각 차원마다 괄호를 별도로 사용한다.
            // - 배열은 레퍼런스(Reference)타입이다.
            // - 배열을 다른 객체나 메소드에 전달할 때, 직접 모든 데이터를 복사하지 않고, 배열 전체를 가리키는 참조 값만을 전달한다.
            // 1차 배열
            string[] array01 = new string[10];
            string[] array02 = { "서울", "경기", "부산" };

            // 2차 배열 선언 및 초기화
            string[,] array03 = { { "김과장", "경리부","26세" }, { "이과장", "총무부","32세" } };

            // 3차 배열 선언
            string[, ,] array04;

            //Jagged Array(가변배열)
            //1차 배열의 크기는 명시해야 한다.
            int[][] array05 = new int[3][];

            //각 1차 배열 요소당 서로 다른 크기의 배열 할당이 가능하다.
            array05[0] = new int[2];
            array05[1] = new int[3] { 1,2,3 };
            array05[2] = new int[4] { 1, 2, 3, 4 };
            array05[0][0] = 1;
            array05[0][0] = 2;

            /** 5. 문자열 */
            // - C#문자열은 Immutable type이므로 한번 문자열이 설정되면 다시 변경할 수 없다. (값을 계속 변경할 수 잇는 것을 Mutable Type이라 한다.)
            // - 예를 들어 문자열 변수 s가 있을 때, s = "Hello";라고 한뒤, 다시 s = "World";라고 하면
            //   .NET시스템에서는 새로운 string객체를 생성해서 "World"라는 데이터로 초기화 한 후 이를 변수s에 할당한다.
            //   해서 변수s는 내부적으로는 전혀 다른 메모리를 갖는 객체를 가리키게 된다.
            // - 문자열은 문자의 집합체이다. 문자열 안에있는 각 문자를 엑세스하고 싶다면, 인덱스를 사용하여 문자요소를 엑세스한다.
            // - 문자배열을 문자열로 변환가기 위해서는 new string을 사용한다.
            string string03 = "Hello";
            char char02 = string03[0]; // H
            char[] charArray01 = {'H','e','l','l','o'};
            string string04 = new string(charArray01); //Hello

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
            }
            string s = sb.ToString();

            Console.WriteLine(s);

        }
        
    }
}
