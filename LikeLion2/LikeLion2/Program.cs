﻿using System;
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
            // 부호 있는 정수: 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50; // 1바이트 크기
            short signedShort = -32000; // 2바이트 크기
            int signedInt = -2000000000; // 4바이트 크기
            Console.WriteLine(signedByte); // 출력: -50
            Console.WriteLine(signedShort); // 출력: -32000
            Console.WriteLine(signedInt); // 출력: -2000000000
        }
    }
}
