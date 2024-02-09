using  x=System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO.Pipes;

public class Program
    {

      int a = 0, b = 0, flag = 0;
       int c = 0, d = 1,e=0,n=0;
    int[] r = { 1, 5, 3, 7, 2, 8, 4 };
    int s = 0;
    int answ=0;
      public void prime1()
        { 
            x.WriteLine(" Enter the number");
             a = int.Parse(x.ReadLine());
        for (int i = 2; i <= a / 2; i++)
        {
            if (a%i== 0)
            {
                flag = 1;
                break;
            }
        }

        if (flag == 0)
        {
            x.WriteLine(a + "The number is Prime number");
        }
        else { x.WriteLine(a + ":   The number is Not the Prime number"); }



      }

    public void fib()
      { x.WriteLine("Enter the number For obtaining the fibs");
        n=int .Parse(x.ReadLine());
        x.Write(c);
        x.Write(d);
         e = c + d;
        //for(int i = 2; i <= n; i++)
        while (e <= n)
        {
            x.Write(e);
            c = d;
            d = e;
            e = c + d;


        }
      }



    public void reverse1()
    {
        r[0] = 33;
        x.WriteLine("Enter the number which you want to search");

        s = int.Parse(x.ReadLine());
        for (int j = 0; j < r.Length; j++)
        {
            if (s == r[j]) { x.WriteLine("the Number is at index" + j); }
            //else { break; }
        }
       
        x.Write("Array is:");
        Array.Reverse(r);
        /*for (int j=1;j<=r.Length;j++)
        { //x.Write(x.ReadLine());
            r[r.Length-1-j] = r[j];
           
      //  Array.Reverse(r)
        }
        */
        for (int j = 0; j <r.Length; j++)
        {
            x.Write(r[j]+" ");

        }
        x.WriteLine();
           
        x.WriteLine("The addition of the array");
            for (int j = 0; j < r.Length; j++)
            {
             answ += r[j];
        
            }
        x.WriteLine(answ);
    }
    public void loop1()
    {
        foreach (int i in r)
        { x.Write(i+" "); }
    }


public static void Main()
        {
        

        Program p1 = new Program();
         // p1.prime1();
        //p1.fib();
        p1.reverse1();
       // p1.loop1();
 
           //x.WriteLine("");
          x.ReadKey();
        }
    }

