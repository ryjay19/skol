using System;

class Program {
  
    static void Main()  {
     
        Console.Write("Daily Rate : ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Days of work :  ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("OT Hours : ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("ㅤ");
        
        double n4 = (n1 / 8 * n3);
        Console.WriteLine("OT PAY : " + n4.ToString("F2"));
        
        double t = (n1 * n2 + n4);
        Console.WriteLine("Gross Pay : " + t.ToString("F2"));    
        
        double n5 = (t * 0.10);
        Console.WriteLine("Tax : " + n5.ToString("F2"));
        
        Console.Write("Vale/CA : ");
        double n6 = Convert.ToDouble(Console.ReadLine());
        
        double n7 = (n5 + n6);
        Console.WriteLine("Total Deduction : " + n7.ToString("F2"));
        
        double n8 = (t - n7);
        Console.WriteLine("Net Pay : " + n8.ToString("F2"));
    }
}
