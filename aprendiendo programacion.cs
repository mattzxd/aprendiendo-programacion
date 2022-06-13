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

using System; 

public class HelloWorld
{
    static int locr = 550;
       static int emp = 600;
       static int hum = 150;
       static int serv = 50;
       static string strServ = "Valor del Servicio: $"+serv;

    public static void Main(string[] args)
    {
      Console.WriteLine ("Cuantos platos de locro consumio la mesa: ");
      int cantL = Convert.ToInt32(Console.ReadLine());
      int precL = locr * cantL;

      Console.WriteLine ("Cuantas docenas de empanadas consumio la mesa:");
        int cantE = Convert.ToInt32(Console.ReadLine());
        int precE = emp * cantE;
    
    Console.WriteLine ("Cuantas humitas consumio la mesa:");
        int cantH = Convert.ToInt32(Console.ReadLine());
        int precH = hum * cantH;
    
    Console.WriteLine (strServ);

    int total = precL + precE + precH + serv;

    Console.WriteLine ("Valor total de la cuenta es: $"+total);
    double prop = total * 0.10;
    Console.WriteLine ("Propina sugerida: $"+prop);

    }
}

using System; 

public class HelloWorld

{
    public static void Main(string[] args)
    {
    Console.WriteLine("Ingrese un valor para a: ");
        double a = Convert.ToDouble(Console.ReadLine());
    if (a!=0){
    Console.WriteLine("Ingerese un valor para b:");
        double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese un valor para c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double Discriminante1 = (System.Math.Pow(b,2)-(4*a*c));
    if (Discriminante1 >= 0){
        double x1 = ((-b) + System.Math.Sqrt(Discriminante1))/(2*a);
        double x2 = ((-b) - System.Math.Sqrt(Discriminante1))/(2*a);
    Console.WriteLine("El reseultado de X1= "+x1+"y X2= "+x2);
    }
    else {
    Console.WriteLine("No existen raices. Pelotudo.");
    }
  
    } else {
    Console.WriteLine("Vos sos tonto o te apellidas Mocchi?");
    }
    }

 using System; 

public class HelloWorld

{
    public static void Main(string[] args)
    {
        int i = 0;
        // for (inicio ; condicion ; paso)
        for (i; i<10 ;i++){
            System.Console.WriteLine(i);
        }



    }
}


 using System; 

public class HelloWorld

{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Ingrese el angulo A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Ingrese el angulo B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Ingrese el angulo C: ");
        double c = Convert.ToDouble(Console.ReadLine());

    if (a+b+c == 180){
        if (a>90 || b>90 || c>90) {
            System.Console.WriteLine("El triangulo es un obtusangulo.");
        } else {
            if (a==90 || b==90 || c==90) {
                System.Console.WriteLine("El triangulo es un rectangulo.");
            } else {
                System.Console.WriteLine("El triangulo es un acutangulo.");
            }
        } 

    } else {
        System.Console.WriteLine("No es un triangulo, gil.");
    }

    }
}
*/

   
 using System; 

public class HelloWorld

{
    public static void Main(string[] args)
    {   
    System.Console.WriteLine("Numeros multiplos de 2 y 5");
    Console.WriteLine("Cantidad de valores a ingresar: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    int multiploDeDos = 0;
    int multiploDeCinco = 0;
    for (int i = 0; i<cantidad; i++)
        {          
        Console.WriteLine("Ingrese los valores:");
        int multiplo = Convert.ToInt32(Console.ReadLine());
        for (int x = 0; x<1; x++){
            int mob2 = multiplo % 2;
            int mob5 = multiplo % 5;
            if (mob2 == 0){
                multiploDeDos += 1;
            } else {
                if (mob5 == 0) {
                multiploDeCinco += 1;
                }
            }
            }
        }
    System.Console.WriteLine("Hay " +multiploDeDos+" multiplos de 2 y "+multiploDeCinco+" multiplosde 5.");
        } 
    
}

       


  