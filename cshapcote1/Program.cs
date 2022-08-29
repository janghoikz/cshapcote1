using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static public string solution(int a, int b)
        {
            string answer = "";
            // 각 달마다 날짜수 배열
            int[] month = new int[13] { 0, 31, 29, 31,
                30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //각 날짜 마다 해당하는 글자
            string[] day = new string[7] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
            int sum = 0;
            //포문에 달의 입력값에 따라 sum에 글추가
            for (int i = 1; i < a; i++)
            {
                sum += month[i];
            }
            //배열이 0부터 시작하기때문에 -1해줌
            sum += (b - 1);
            answer = day[sum % 7];
            Console.WriteLine(answer);
            return answer;
        }
        static void Main(string[] args)
        {
            solution(6,18);
        }
    }
}