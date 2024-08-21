
double masa;
double velocidad;

Console.WriteLine("Ingrese la masa ");
masa = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Ingre la velosidad  ");
   velocidad  = Convert.ToDouble(Console.ReadLine());

double ec  =  0.5 * masa * (velocidad * velocidad);

Console.WriteLine($"La energia cinetica es de {ec:f}j ");