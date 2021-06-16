using System;
using System.Text.RegularExpressions;
using System.Linq;
// 신규 아이디 추천 : https://programmers.co.kr/learn/courses/30/lessons/72410
public class Solution_20210614_1
{
    public string solution(string new_id)
    {
        string lower_str = new_id.ToLower();
        lower_str = Regex.Replace(lower_str, "[^a-z0-9-_.]", String.Empty);
        int cnt = 0;
        // string ch = "..";
        bool res = true;
        while (res){
            cnt = Regex.Matches(lower_str, @"\.\.").Count;
            res = cnt >= 1;
            // Console.WriteLine("cnt는 {0}, res는 {1}", cnt, res);
            if (res){
                lower_str = lower_str.Replace("..",".");
            }
        }
        if ( lower_str.Length >=1){
            if (lower_str[0] == '.'){
                lower_str = lower_str.TrimStart('.');
            }
        }
        if ( lower_str.Length >=1){
            if (lower_str[lower_str.Length-1] == '.'){
                lower_str = lower_str.TrimEnd('.');
            }
        }
        if (lower_str.Length == 0){
            lower_str+= "a";
        }
        if (lower_str.Length >=16){
            lower_str= lower_str.Substring(0,15);
            if (lower_str[lower_str.Length-1] == '.'){
                lower_str = lower_str.TrimEnd('.');
            }
        }
        if (lower_str.Length <=2){
            char cha = lower_str[lower_str.Length-1];
            while (lower_str.Length < 3){
                lower_str += cha;
            }

        }
        return lower_str;
    }
}