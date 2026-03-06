/*class Program
{   
static string usuarioGuardado = "";
static string claveGuardada = "";
    static void Main()
{
        
Desafio1();

        
Desafio2();

       
Desafio3();
}

    //  Parte 1 - Desafío 1 
    static void Desafio1()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Mes 1: ");
        double mes1 = double.Parse(Console.ReadLine());
        Console.Write("Mes 2: ");
        double mes2 = double.Parse(Console.ReadLine());
        Console.Write("Mes 3: ");
        double mes3 = double.Parse(Console.ReadLine());

        double suma = mes1 + mes2 + mes3;
        double promedio = suma / 3;

        Console.WriteLine("Hola " + nombre +
            ", en total ganaste " + suma +
            " y promediaste " + promedio);
    }

    //  Parte 1 - Desafío 2 
    static void Desafio2()
    {
        Console.Write("Numero 1: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Numero 2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma: " + Operaciones.Sumar(n1, n2));
        Console.WriteLine("Resta: " + Operaciones.Restar(n1, n2));
        Console.WriteLine("Multiplicacion: " + Operaciones.Multiplicar(n1, n2));
        Console.WriteLine("Division: " + Operaciones.Dividir(n1, n2));
    }

    // ---------- Parte 1 - Desafío 3 ----------
    static void Desafio3()
    {
        try
        {
        Console.Write("Ingrese primer número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int suma = num1 + num2;
        Console.WriteLine("La suma es: " + suma);
        }
        catch
        {
            Console.WriteLine("Error: Debe ingresar un número válido.");
        }
        finally
        {
            Console.WriteLine("Desafío 3 finalizado.");
        }
    }
}
class Operaciones
{
    public static int Sumar(int a, int b) { return a + b; }
    public static int Restar(int a, int b) { return a - b; }
    public static int Multiplicar(int a, int b) { return a * b; }
    public static int Dividir(int a, int b) { return a / b; }
}

//Parte 2: Desafíos 1 
class Program
{
static string usuarioGuardado;
static string claveGuardada;

static void Registrar()
{
    Console.Write("Crear usuario: ");
    usuarioGuardado = Console.ReadLine();

    Console.Write("Crear contraseña: ");
    claveGuardada = Console.ReadLine();

    Console.WriteLine("Registro completado");
}

static void IniciarSesion()
{
    Console.Write("Usuario: ");
    string usuario = Console.ReadLine();

    Console.Write("Contraseña: ");
    string clave = Console.ReadLine();

    if (usuario == usuarioGuardado && clave == claveGuardada)
    {
        Console.WriteLine("Inicio de sesión correcto");
    }
    else
    {
        Console.WriteLine("Usuario o contraseña incorrectos");
    }
}
static void Main()
{
    Registrar();
    IniciarSesion();
}
}

//parte 2: Desafío 2
class Program
{static int puntajeRecord = 0;
static string jugadorRecord = "";
 static void VerificarRecord(int puntaje, string nombreJugador)
 {
    if (puntaje > puntajeRecord)
    {
    puntajeRecord = puntaje;
    jugadorRecord = nombreJugador;

    Console.WriteLine("La nueva puntuación más alta es " + puntajeRecord);
    Console.WriteLine("La puntuación más alta fue lograda por " + jugadorRecord);
    }
    else
    {
    Console.WriteLine("La puntuación más alta de " + puntajeRecord +
    " no se ha podido superar, y aún está en manos de " + jugadorRecord);
    }
    }

static void Main()
{
    VerificarRecord(100, "Dayani");
    VerificarRecord(50, "Glendy");
     VerificarRecord(150, "Yovi");
 }
}*/
