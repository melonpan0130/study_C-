using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCP_lec2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 100; // var -> System.Int32
            // number = "100"; x 문자열 안됨(이미 int이기 때문에)

            var lotto = 10000000000L; // System.Int64 long
            var str = "안녕하세요"; // System.String
            var this_double = 3.141592; // System.Double
            var this_float = 3.14F; // System.Single
            var this_bool = true; // System.Boolean
            var this_char = 'H'; // System.Char

            Console.WriteLine("number: " + number.GetType()); // System.Int32
            Console.WriteLine("lotto: " + lotto.GetType()); // System.Int64
            Console.WriteLine("str: " + str.GetType()); // System.String
            Console.WriteLine("this_double: " + this_double.GetType()); // System.Double
            Console.WriteLine("this_float: " + this_float.GetType()); // System.Single
            Console.WriteLine("this_bool: " + this_bool.GetType()); // System.Boolean
            Console.WriteLine("this_char: " + this_char.GetType()); // System.Char

            Console.WriteLine("int형 최대" + int.MaxValue);
            Console.WriteLine("int형 최소" + int.MinValue);
            Console.WriteLine("long형 최대" + long.MaxValue);
            Console.WriteLine("long형 최소" + long.MinValue);
            Console.WriteLine("float형 최대" + float.MaxValue);
            Console.WriteLine("float형 최소" + float.MinValue);
            Console.WriteLine("double형 최대" + double.MaxValue);
            Console.WriteLine("double형 최소" + double.MinValue);
            Console.WriteLine("char형 최대" + char.MaxValue); // 특이하군; 63에 해당하는 문자표 ?이 출력됨
            Console.WriteLine("char형 최소" + char.MinValue); // 20에 해당하는 공백이 출력됨
            // Boolean은 최대값 최소값이 없음

            /*
            for(char i=char.MinValue; i<char.MaxValue; i++)
            {
                Console.Write(i + ""); // 모든 문자를 출력
                // 인코딩 방식의 영향을 받음
            }*/

            // Literal 리터럴 
            int i_int = 100;
            long i_lng = 100L;
            double i_dbl = 100.0;
            float i_flt = 100.0F;
            char i_chr = 'A';

            // 자료형의 표현 크기 (암묵적 형변환 가능) Type Casting
            i_dbl = i_flt = i_lng = i_int = i_chr;
            // double < float < long < int < char

            
            string strInt = "50";
            string strLong = "20000000000"; // 200억
            string strDouble = "50.0";
            string strFloat = "50.0";
            string strString = "ABCDE";

            try // 에러 발생 방지; 사용자에게 입력 받을 때는 무조건 꼭 예외코드를 잘 써주어야 함
            {
                Console.WriteLine(int.Parse(strInt));
                Console.WriteLine(long.Parse(strLong));
                Console.WriteLine(double.Parse(strDouble));
                Console.WriteLine(float.Parse(strFloat));
                Console.WriteLine(double.Parse(strString)); // 형식 에러 발생!
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("형식 에러 발생!");
                Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            bool trueOrFalse = true;
            Console.WriteLine(trueOrFalse.ToString()); // True; 첫글자가 대문자

            int a = 1999;
            Console.WriteLine("" + a);

            char c = 'a';
            string c2 = "" + 'a';
            Console.WriteLine(c2);
        }
    }
}
