//Declacion de vareibles 
double peso;
double altura;
double IMC;

//solisitar datos al usuario
Console.WriteLine("Ingrese su peso en kilogramo");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese su altura en metro");
altura = Convert.ToDouble(Console.ReadLine());

IMC = peso / (altura * altura);

Console.WriteLine($"su IMC es de: {IMC:f}");
if (IMC < 18.5)
{
    Console.WriteLine("Tu imc dice que estas bojo de peso");

}
