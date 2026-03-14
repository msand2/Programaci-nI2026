class Program
{
static void Main()
{

    // DESAFIO 1
     Console.WriteLine("Ingrese un número entero positivo:");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Numeros pares desde 1 hasta " + numero);

    for (int i = 1; i <= numero; i++)
    {
    if (i % 2 == 0)
     {
        Console.WriteLine(i);
        }
    }


    // DESAFIO 2
    Console.WriteLine("Ingrese un numero entero positivo:");
    int numero2 = Convert.ToInt32(Console.ReadLine());

     bool esPrimo = true;

    for (int i = 2; i < numero2; i++)
    {
        if (numero2 % i == 0)
        {
        esPrimo = false;
        Console.WriteLine("El numero no es primo.");
        break;
        }
    }

    if (esPrimo == true)
    {
        Console.WriteLine("El numero es primo.");
    }


        // DESAFIO 3
int suma = 0;
int contador = 0;
string entrada;

Console.WriteLine("Ingrese notas (1-10). Escriba fin para terminar.");

while (true)
{
    entrada = Console.ReadLine();

    if (entrada == "fin")
        break;

        int nota = int.Parse(entrada);

        suma += nota;
        contador++;
    }

    int promedio = suma / contador;
    Console.WriteLine("Promedio: " + promedio);
}
}