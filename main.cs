using System;

class MainClass {
  public static void Main (string[] args) {
            bool flag;
            int num, n = 69;
            int n1 = 5, n2 = 11, n3 = 19;
            char c = 'H';
            double x = 13.3333;
            num = (int)x;
            Console.WriteLine(num);
            Console.WriteLine((char)n);
            num = (int)c;
            Console.WriteLine(num);           
            flag= (n1 == n2) || (n2 != n3) && (n1 > n3);
            Console.WriteLine(!flag);
            num = n2 % 3;
            Console.WriteLine(num);
  }
}