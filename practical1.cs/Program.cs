using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate int Arithop(int x, int y);

class mathop
{
    public static int add(int x, int y)
    {
        return (x + y);
    }
    public static int subtrac(int x, int y)
    {
        return (x - y);
    }
}
class testD
{
    public static void Main()
    { 
    Arithop op1 = new Arithop(mathop.add);
    Arithop op2 = new Arithop(mathop.subtrac);
    int result1 = op1(200, 100);
    int result2 = op2(200, 100);
    Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.ReadKey();
 
   }







}