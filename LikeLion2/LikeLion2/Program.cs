using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수 데이터 형식: 소수점이 없는 숫자를 표현
            int intValue = -100; // 4바이트 크기의 정수
            long longValue = 1234567890L; // 8바이트 크기의 정수

            Console.WriteLine(intValue); // 출력: -100
            Console.WriteLine(longValue); // 출력: 1234567890
        }
    }
}
