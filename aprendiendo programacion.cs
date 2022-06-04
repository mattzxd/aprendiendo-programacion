/*          
using System; || Ejercicio 5

public class HelloWorld
{
    public static void Main(string[] args)
    {
                Console.WriteLine ("Ingresa el valor entero de A:");
        int a =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Ingresa el valor entero de B:");
        int b =  Convert.ToInt32(Console.ReadLine());
        int suma = a + b;
        Console.WriteLine ("El resultado de a+b es "+suma);

        Console.WriteLine ("Ingresa su nombre:");
        String nombre = Console.ReadLine();
        Console.WriteLine ("Hola "+nombre+", alias amante de Mocchi.");

        Console.WriteLine ("Ingresa el valor entero de A: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine ("Ingresa el valor entero de B: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        int producto = a1 * b1;
        Console.WriteLine ("El resultado de a*b es "+producto);

        int a = 33; 
        int b = 4;
        int div = a/b;
        int mod = a%b;
        Console.WriteLine ("div: "+div + " mod: "+mod);

        bool a = 15 > 30;
        bool b = 15 > 30;
        bool c = 15 == 30;
        bool d = 15 != 30;
        bool e = !a;
        Console.WriteLine ("a "+a+"\nb "+b+"\nc "+c+"\nd "+d+"\ne "+e);

        Console.WriteLine ("Ingresa el valor entero de A: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine ("Ingresa el valor entero de B: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        if(a1 >= b1){
            Console.WriteLine ("El valor de A es mayor o igual al valor de B");
        } else{
            Console.WriteLine ("El valor de A es menor al valor de B");
        }

        Console.WriteLine ("Cantidad de horas trabajadas:");
        int hts = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Valor en $(pesos argentinos) por hora trabajada:");
        double pph = Convert.ToDouble(Console.ReadLine());
        double SAL;
        if(hts > 35){
            int extra = hts - 35;
            double prod = extra * (pph * 1.5);
            SAL = prod + (pph * 35);
        } else{
            SAL = hts * pph;
        }
        Console.WriteLine ("Usted percibira $"+SAL+" por sus horas brindadas");
    }
}
*/


using System; 

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Ingrese el numero de dos digitos que quiere invertir su valor:");
       int num = Convert.ToInt32(Console.ReadLine());
       int div = num / 10;
       int mod = num % 10;

       Console.WriteLine("Su valor invertido es:"+mod+div);
       
    }
}

using System; 

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Ingrese el numero de tres digitos que quiere invertir su valor:");
       int num = Convert.ToInt32(Console.ReadLine());
       int div = num / 100;
       int mod = num % 100;
       int div10 = mod / 10;
       int mod10 = mod %10;
       
       Console.WriteLine("Su valor invertido es:"+mod10+div10+div);
       
    }
}


