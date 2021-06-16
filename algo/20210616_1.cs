using System;
using System.Collections.Generic;

// 문제 : https://programmers.co.kr/learn/courses/30/lessons/1845
public class Solution_20210616_1
{
    public int solution(int[] nums)
    {
        var set_nums = new HashSet<int>(nums);
        int len_criteria = nums.Length / 2;
        if( set_nums.Count > len_criteria){
            return len_criteria;
        }
        else{
            return set_nums.Count;
        }
    }

}