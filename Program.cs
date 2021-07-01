using System;

namespace Aplicacion_2_3er_Bim_Pedro_Javier
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                //Declaracion de variables 
                int Valor1 = 0;
                int Valor2 = 0;
                int Total = 0;
                int Operacion = 0;
                bool entorno = true;
                char op = 's';


                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Desea realizar una operacion");
                Console.WriteLine("s para realizar una operacion");
                Console.WriteLine("Cualquier otro dato de un igito para no");
                while (entorno == true)
                    try 
                    {
                        Console.WriteLine("Digite la opcion que desea");
                        op = char.Parse(Console.ReadLine());
                        entorno = false;
                    }
                    catch
                    {
                        Console.WriteLine("Error Dato Ingresado No valido");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                Console.WriteLine("----------------------------------------------");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                while (op == 's')
                {
                    entorno = true;
                    while (entorno == true)
                    {
                        //valor 1
                        Console.Write("Ingrese el primer valor: ");
                        try
                        {
                            Valor1 = int.Parse(Console.ReadLine());
                            entorno = false;
                        }
                        catch
                        {
                            Console.WriteLine("Error Dato Ingresado No valido");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }

                    // Valor2 
                    entorno = true;
                    while (entorno == true)
                    {

                        Console.Write("Ingrese el segundo valor: ");
                        try
                        {
                            Valor2 = int.Parse(Console.ReadLine());
                            entorno = false;
                        }
                        catch
                        {
                            Console.WriteLine("Error Dato Ingresado No valido");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }

                    Console.WriteLine("----------------------------------------------");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");


                    entorno = true;
                    while (entorno == true)
                    {
                        Console.WriteLine("Que operacion desea realizar \n1. Multiplicar \n2. Dividir \n3. Sumar \n4. Restar");
                        
                        try
                        {
                            Console.WriteLine("Digite la opcion que desea");
                            Operacion = int.Parse(Console.ReadLine());
                            entorno = false;
                        }
                        catch
                        {
                            Console.WriteLine("Error Dato Ingresado No valido");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }
                    if (Operacion == 1)
                    {
                        Total = Valor1 * Valor2;
                    }
                    else if (Operacion == 2)
                    {
                        Total = Valor1 / Valor2;
                    }
                    else if (Operacion == 3)
                    {
                        Total = Valor1 + Valor2;
                    }
                    else if (Operacion == 4)
                    {
                        Total = Valor1 - Valor2;
                    }
                    else if (Operacion == 5)
                    {
                        break;
                    }

                    Console.WriteLine("----------------------------------------------");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();



                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("El total es: "+ Total);
                    Console.WriteLine("Desea Realizar Otra Opreacion");
                    Console.WriteLine("s para realizar una operacion");
                    Console.WriteLine("Cualquier otro dato de un digito para no");
                    entorno = true;
                    while (entorno == true)
                        try
                        {
                            Console.WriteLine("Digite la opcion que desea");
                            op = char.Parse(Console.ReadLine());
                            entorno = false;
                        }
                        catch
                        {
                            Console.WriteLine("Error Dato Ingresado No valido");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    Console.WriteLine("----------------------------------------------");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();


                }
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Gracias Por Usar la Aplicacion");
                Console.WriteLine("Creditos");
                Console.WriteLine("Pedro Javier Serrano Ramírez");
                Console.WriteLine("----------------------------------------------");

            }
        }
    }
}

