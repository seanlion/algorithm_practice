using System;
using System.Collections.Generic;

// 문제 : https://programmers.co.kr/learn/courses/30/lessons/43165?language=csharp
public class Solution_20210616_2
{
   public int solution(int[] numbers, int target) {
        int answer = 0;
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
        queue.Enqueue(new Tuple<int, int> (0,numbers[0]));
        queue.Enqueue(new Tuple<int, int> (0,-numbers[0]));

        while ( queue.Count > 0){
            // var item = queue.Dequeue();
            var (idx, num_sum) = queue.Dequeue();
            // int idx = item[0];
            // int num_sum = item[1];
            idx+=1;
            if (idx < numbers.Length){
                queue.Enqueue(new Tuple<int, int> (idx, num_sum + numbers[idx]));
                queue.Enqueue(new Tuple<int, int>(idx, num_sum - numbers[idx]));
            }
            if (idx == numbers.Length && num_sum == target){
                answer +=1;
            }
        }
        return answer;
    }

}