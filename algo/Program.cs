using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace algo
{
    public class Program {
        static void Main() {
            // 신규 아이디 추천 : https://programmers.co.kr/learn/courses/30/lessons/72410
            object answer;
            string[] test_case = {"...!@BaT#*..y.abcdefghijklm", "z-+.^.", "=.=","123_.def","abcdefghijklmn.p"};
            string ansStr = "[ ";
            ArrayList ar = new ArrayList();
            for (int i=0; i<test_case.Length; i++){
                answer = new Solution_20210614_1().solution(test_case[i]);
                ar.Add(answer);
            }
            // 테스트 케이스 출력
            foreach (var item in ar)
            {
                ansStr += $"{item} | ";
            }
            Console.WriteLine($"{ansStr}]");
        }
    }
}
