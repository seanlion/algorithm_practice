using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace algo
{
    public class Program {
        static void Main() {
            object answer;
            // string[] test_case = {"...!@BaT#*..y.abcdefghijklm", "z-+.^.", "=.=","123_.def","abcdefghijklmn.p"};
            // int[][] test_case = new int[][] { new int[] {1,2,3,4,5}, new int[] {1,3,2,4,2}};
            // int[][] test_case = new int[][] { new int[] {3,1,2,3}, new int[] {3,3,3,2,2,4}, new int[] {3,3,3,2,2,2}};
            int[][] test_case = new int[][] { new int[] {1, 1, 1, 1, 1}};
            string ansStr = "[ ";
            ArrayList ar = new ArrayList();
            for (int i=0; i<test_case.Length; i++){
                // answer = new Solution_20210614_1().solution(test_case[i]);
                // answer = new Solution_20210615_1().solution(test_case[i]);
                // answer = new Solution_20210616_1().solution(test_case[i]);
                answer = new Solution_20210616_2().solution(test_case[i],3);
                ar.Add(answer);
            }
            // 테스트 케이스 출력
            foreach (var item in ar)
            {
                if (item.GetType() == typeof(ArrayList)){
                    string subStr = "[";
                    foreach (var i in item as ArrayList){
                        subStr += $"{i},";
                    }
                    subStr += "]";
                    ansStr += $"{subStr} | ";
                }
                else {
                    ansStr += $"{item} | ";
                }                
                // Console.WriteLine("ar의 item {0}", item);
            }
            Console.WriteLine($"{ansStr}]");
        }
    }
}
