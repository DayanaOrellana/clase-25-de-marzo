

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

void Adivina()
{ 
    const int Oportunidades = 4;
    int numeroCPU, numerosUsuario;
    byte Intentos, BanderaControl;
    string linea;

    Random rand = new Random();

do
{
    numeroCPU = Convert.ToInt32(rand.Next(100));
} while (!((numeroCPU >= 1) & (numeroCPU <= 20)));

//Proceso
Intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("Hola estoy pensando en un numero, cual crees que es ");
        numerosUsuario = Convert.ToInt32(Console.ReadLine());
    BanderaControl = 1;
        if (numerosUsuario > numeroCPU)
        {
            Console.WriteLine("blablabla");
        }
        else
        {
            Console.WriteLine("Blablabla");
        }
        Intentos++;

    }
    while (((Intentos <= Oportunidades) & (BanderaControl == 0)));
    if (BanderaControl== 0)
    {
        Console.WriteLine("El numero que pense era:" + numeroCPU);
    }
}
//Adivina();
void buscaMayor()
{
    int mayor = 0;
    int numero = 0;
    Random rand = new Random();
    for (int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);
        if (numero > mayor)
        {
            mayor = numero;
        }
    }
    Console.WriteLine("El numero mayor es:" + mayor);
}
//buscaMayor();
void arreglos()
{
    int[] notas = new int[10];
    Random rnd = new Random();
    Console.WriteLine("Cargando informacion");

    for (int i=0; i<20; i++)
    {
        notas[i] = rnd.Next();
    }
    Console.WriteLine("Despelgando informacion: ");
    int mayor = 0;
    int promedio = 0;
    for (int i=0; i< notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }
    Console.WriteLine("Nota mayor" + mayor);
}
//arreglos();

void nombres()
{
    String[] nombre = new string[11];
    nombre[0] = "Jairo";
    nombre[1] = "Brandom";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Stephanie";
    nombre[6] = "Eduardo";
    nombre[7] = "Jose";
    nombre[8] = "Marielos";
    nombre[9] = "Michel";
    nombre[10] = "Cristina";


    //for (int i=0; i< nombre.Length; i++)
    // {
    // Console.WriteLine(i + ":" + nombre[i]);
    // }
    Random rnd = new Random();
    int ganador1 = rnd.Next(0, nombre.Length);
    int ganador2;
    do
    {
        ganador2 = rnd.Next(0, nombre.Length);
    }
    while (ganador2 == ganador1);

    ganador1 = nombre[ganador1];
    ganador2 = nombre[ganador2];
    Console.WriteLine("El ganador del primer lugar es:"+ganador1);
    Console.WriteLine("El ganador del segundo lugar es:"+ganador2);
}
nombres();

