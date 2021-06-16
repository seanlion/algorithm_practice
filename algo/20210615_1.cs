using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

// 문제 : https://programmers.co.kr/learn/courses/30/lessons/42840
public class Solution_20210615_1
{
    public ArrayList solution(int[] answers)
    {
        int[][] supo_patterns = new int[3][];
        supo_patterns[0] = new int[] {1,2,3,4,5};
        supo_patterns[1] = new int[] {2,1,2,3,2,4,2,5};
        supo_patterns[2] = new int[] {3,3,1,1,2,2,4,4,5,5};
        var sheet = new Dictionary<int, int>();

        for (int c=0; c<3; c++){
            int[] sudo_p = supo_patterns[c];
            int i=0;
            int tmp = 0;
            foreach (var ans in answers){
                if (ans == sudo_p[i]){
                    // 만들고자 하는 로직 : 딕셔너리 키의 값에 1을 더한다. 딕셔너리 키가 없으면 만들고(디폴트 값) 그 키의 기존 값을 더한다.
                    // 짜야 하는 로직 : 키가 있으면, dict[key]에다가 더하고, 키가 없으면, 키와 디폴트 값을 추가한다.
                    if (sheet.TryGetValue(c+1,out tmp)){
                        sheet[c+1]= sheet[c+1] + 1;
                    }
                    else {
                        sheet.Add(c+1,0);
                    }
                    // Console.WriteLine("sheet는 {0}", sheet.Keys);
                }
                i+=1;
                if (i == sudo_p.Length){
                    i=0;
                }
            }
        }
        foreach (var item in sheet){
            Console.WriteLine("sheet 내부 : {0}", item);
        }
        var mx = sheet.Values.Max();
        // Console.WriteLine("딕셔너리 Values 타입은 : {0}, {1}", sheet.Values, sheet.Values.GetType());
        // Console.WriteLine("딕셔너리 Values Max는: {0}, {1}", mx,mx.GetType());
        ArrayList answer = new ArrayList();
        foreach (var item in sheet){
            if (item.Value == mx){
                // Console.WriteLine("item의 키는 {0}", item.Key);
                answer.Add(item.Key);
            }
        }
        return answer;
    }

}