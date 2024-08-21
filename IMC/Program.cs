//Declaracion de variable
double peso;
double altura;
double imc;

//solicitar los datos
Console.WriteLine("ingrese su peso en kg");
peso = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("Ingrese su altura en metros");
altura  = Convert.ToDouble(Console.ReadLine());

//calcular el imc
imc = peso / (altura * altura) ;

// mostrar el imc
Console.WriteLine($"Su IMC es: {imc:F2}");