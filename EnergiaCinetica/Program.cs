double masa;
double velocidad;
double ec;

Console.WriteLine("Escribe la masa");
masa=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe la velocidad");
velocidad=Convert.ToDouble(Console.ReadLine());

ec = (1/2) *masa*( velocidad * velocidad);

Console.WriteLine($"Su Energia Cinetica es: {ec:F2}");


