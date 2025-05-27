// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora c = new Calculadora();
/*
c.Dato = 0;
Console.WriteLine($"El valor de la variable es {c.Resultado}");
c.Sumar(5);
Console.WriteLine($"El valor de la variable sumando 5 es {c.Resultado}");
c.Restar(2);
Console.WriteLine($"El valor de la variable restando 2 es {c.Resultado}");
c.Multiplicar(3);
Console.WriteLine($"El valor de la variable multiplicado por 3 es {c.Resultado}");
c.Dividir(2);
Console.WriteLine($"El valor de la variable dividido por 2 es {c.Resultado}");
c.Limpiar(0);
Console.WriteLine($"El valor de la variable deberia ser 0  y es {c.Resultado}");
*/

int opc, entrada;
do
{
    Console.WriteLine("\n\t\tCalculadora\n\t1. Sumar\n\t2. Restar\n\t3. Multiplicar\n\t4. Dividir\n\t5. Limpiar\n\t6. Salir");
    Console.WriteLine("Ingrese una opcion: ");
    if (int.TryParse(Console.ReadLine(), out opc)) ;
    {
        switch (opc)
        {
            case 1:
                Console.WriteLine("Ingrese el valor a sumar: ");
                int.TryParse(Console.ReadLine(), out entrada);
                c.Sumar(entrada);
                break;
            case 2:
                Console.WriteLine("Ingrese el valor a restar : ");
                int.TryParse(Console.ReadLine(), out entrada);
                c.Restar(entrada);
                break;
            case 3:
                Console.WriteLine("Ingrese el valor a multiplicar: ");
                int.TryParse(Console.ReadLine(), out entrada);
                c.Multiplicar(entrada);
                break;
            case 4:
                Console.WriteLine("Ingrese el valor a dividir: ");
                int.TryParse(Console.ReadLine(), out entrada);
                c.Dividir(entrada);
                break;
            case 5:
                Console.WriteLine("Limpiando...");
                c.Limpiar();
                break;
            case 6:
                Console.WriteLine("Saliendo...");
                break;
            default:
                Console.WriteLine("Opcion incorrecta...");
                break;
        }
    }
    Console.WriteLine($"El resultado es: {c.Resultado}");
} while (opc != 6);

