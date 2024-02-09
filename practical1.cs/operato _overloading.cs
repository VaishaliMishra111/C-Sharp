using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class vector
{
    int x, y, z;
    public vector(int a, int b, int c)
    { 
    x = a;
    y = b;
    z = c;}
    public override string ToString()
    {
        return ("(" + x + "," + y + "," + z + ")");

    }
    public static bool operator==(vector u1,vector u2)
    {
        if(u1.x==u2.x && u1.y==u2.y && u1.z==u2.z)
            return true;
        else return false;


    }
    public static bool operator!=(vector u1,vector u2)
    {
        return (!(u1 == u2));

    }

}
class testm
{
    public static void Main()
    {
        vector u1 = new vector(2, 4, 6);
        vector u2 = new vector(4, 5, 6);
        string x = u1.ToString();
        Console.WriteLine("the variable is"+x);

        if (u1==u2)
        {
            Console.WriteLine("both are equal");
        }
        else
        {

            Console.WriteLine("not same");

        }

        Console.ReadKey();
    }

}
