using System;

namespace proj2
{
    public struct MyStruct {
        public int Kor,Eng,Math,Total;
        public float Average;
        public void Compute(){
            Total = Kor+Eng+Math;
            Average = Total / 3.0f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // string str1 = "Hello";
            // string str2 = "World";
            // string str3 = str1+str2;
            // Console.WriteLine("결과: {0}", str3);
            // Console.WriteLine("배열 인덱스 {0}",str1[4]);

            // int value1 = 127;
            // string str1 = value1.ToString();
            // Console.WriteLine("str로 변환 {0}",str1);
            
            // int value2 = Convert.ToInt32(str1);
            // Console.WriteLine("Convert ToInt 사용 {0}",value2);

            // string str2 = "1.34";
            // float value3 = float.Parse(str2);
            // Console.WriteLine("Parse 사용 {0}", value3);

            // struct와 클래스
            MyStruct Test1 = new MyStruct();
            Test1.Kor = 80;
            Test1.Eng = 90;
            Test1.Math = 80;
            Test1.Compute();
            Console.WriteLine("총점 : {0}, 평균 : {1:f1}", Test1.Total, Test1.Average);
        }
    }
}
