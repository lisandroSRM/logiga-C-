// generar clase 
using System.Security.Cryptography;

class Logica
{
    // los void no retornan nada
    public void ejercicio1()
    // Ejercicio 1
    //Escribir un programa que pregunte al usuario su nombre, y luego lo salude.
    {
        Console.WriteLine("Escribe tu nombre");// con esto mostramos algo en pantalla
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola " + nombre);
        Console.ReadKey();
    }
    public void ejercicio2()
    //Ejercicio 2
    //Calcular el perimetro y rea de un recténgulo dada su base y su altura,
    //Perimetro = 2x(base + altura)
    //Area = base x altura
    {
        Console.WriteLine("Escribe la base");
        double baseR = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escribe la altura");
        double altura = Convert.ToDouble(Console.ReadLine());
        double perimetro = 2 * (baseR + altura);
        double area = baseR * altura;
        Console.WriteLine("El perimetro es "+ perimetro + " El area es "+ area);
        Console.ReadKey();
    }
    public void ejercicio3()
    {
        double cateto1 = 3;
        double cateto2 = 4;
        cateto1=Math.Pow(cateto1, 2);
        cateto2 = Math.Pow(cateto2, 2);
        double hipotenusa = Math.Sqrt(cateto1 + cateto2);
        Console.WriteLine("La hipotenusa es  " + hipotenusa);
        Console.ReadKey();
    }
    public void ejercicio4()
    {
        Console.WriteLine("Escribe el numero 1");
        double numero1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escribe el numero 2");
        double numero2=Convert.ToDouble(Console.ReadLine());
        double suma = numero1 + numero2;
        double resta = numero1- numero2;
        double divicion = numero1/ numero2;
        double multiplicacion = numero1* numero2;
        Console.WriteLine("la suma es " + suma + "\n"  
                          + "la resta es "  + resta + "\n"
                          + "la multiploicacion es " + multiplicacion + "\n"
                          + "la divicion es " + divicion );
        Console.ReadKey();
    }
    public void ejercicio5()
    {
        Console.WriteLine("Cuantos °F quieres transformar:");
        double Fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (Fahrenheit - 32)*5 /9;
        Console.WriteLine("Los "+ Fahrenheit + "°F En grados °C son " + celsius);
        Console.ReadKey();

    }
    public void ejercicio6()
    {
        Console.WriteLine("ingresa el primer numero");
        double numero1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ingresa el segundo numero");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ingresa el tercero numero");
        double numero3 = Convert.ToDouble(Console.ReadLine());
        double media = (numero1 + numero2 + numero3) / 3;
        Console.WriteLine("LA media de los 3 numero es " + media);
        Console.ReadKey();
    }
    public void ejercicio7()
    {
        Console.WriteLine("Cuantos minutos quieres transformar:");
        int minutos=Convert.ToInt32(Console.ReadLine());
        int horas = minutos / 60;
        int minRest = minutos % 60;
        Console.WriteLine(minutos+ " Minutos\n Son " + horas +" horas"+ " y los minutos son " + minRest);
        Console.ReadKey();
    }
    public void ejercicio8()
    {
        Console.WriteLine("Precio total de tus ventas en este mes:");
        int ventas =Convert.ToInt32(Console.ReadLine());
        double sueldoBase = 7000;
        double comicion= (ventas / 100) * 10;
        double sueldoTotal =sueldoBase + comicion;
        Console.WriteLine("Tu sueldo Total es de $"+sueldoTotal + " Y el total de tus comiciones fue $" + comicion);
        Console.ReadKey();
    }
    public void ejercicio9()
    {
        Console.WriteLine("Cuanto compraste en mercancia:");
        double mercaPrec = Convert.ToDouble(Console.ReadLine());
        double descuento = mercaPrec * .15;
        Console.WriteLine("Pagaste $" + (mercaPrec - descuento) + " ahorraste $" +
                            descuento);
        Console.ReadKey();
    }
    public void ejercicio10()
    {
        Console.WriteLine("Ingresa la calificacion del 1° parcial:");
        double parcial1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa la calificacion del 2° parcial:");
        double parcial2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa la calificacion del 3° parcial:");
        double parcial3 = Convert.ToDouble(Console.ReadLine());
        double PromedioParciales = ((parcial1 + parcial2 + parcial3) / 3) * .55;
        Console.WriteLine("Ingresa la calificacion de tu examen:");
        double examen = Convert.ToDouble(Console.ReadLine());
        double PromediExamen = (examen * .30);
        Console.WriteLine("Ingresa la calificacion de tu trabajo final:");
        double trabajoFinal = Convert.ToDouble(Console.ReadLine());
        double PromedioTrabajoF = (trabajoFinal * .15);
        double calFinal = PromedioParciales + PromediExamen + PromedioTrabajoF;
        Console.WriteLine("Tu calificacion Final corresponde a :" + calFinal);
        Console.ReadKey();

    } 
    // metodo principal 
    static void Main(string[] args)
    {
        // instanciamos la clase 
        Logica obj = new Logica();
        obj.ejercicio10();

    }
}
