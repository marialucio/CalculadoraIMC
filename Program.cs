Individuo i1 = new Individuo("Ly", 1.65, 80);


Console.WriteLine("-----CALCULADORA IMC-----");

Console.WriteLine("Seu IMC é {0}", i1.IMC);

Console.WriteLine("\nSituação do IMC:");

if (imc < 17)
    Console.WriteLine("Muito abaixo do peso...");

else if (imc >= 17 && imc < 18.5)
    Console.WriteLine("Abaixo do peso...");

else if (imc >= 18.5 && imc <= 24.9)
    Console.WriteLine("Peso normal!");

else if (imc >= 25 && imc <= 29.9)
    Console.WriteLine("Acima do peso...");

else if (imc >= 30 && imc <= 34.9)
    Console.WriteLine("Obesidade I...");

else if (imc >= 35 && imc <= 39.9)
    Console.WriteLine("Obesidade II...");

else
    Console.WriteLine("Obesidade III...");


double pesoIdeal = 0.0;

if (imc < 18.5)
    Console.WriteLine("Para chegar à situação ideal, você deve ganhar {0} kg.", GanharPeso());

else if (imc > 25)
    Console.WriteLine("Para chegar à situação ideal, você deve perder {0} kg.", PerderPeso());

