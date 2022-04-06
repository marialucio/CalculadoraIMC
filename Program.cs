
Console.WriteLine("-----CALCULADORA IMC-----");

Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("\nQual a sua altura em metros? Ex: 1,65");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("\nQual o seu peso em Kg? Ex: 57,4");
float peso = Convert.ToSingle(Console.ReadLine());

double imc = Math.Round(peso / (altura*altura), 1);

Console.WriteLine("\n{0}, sua altura é {1} e seu peso é {2}", nome, altura, peso);

Console.WriteLine("Seu IMC é {0}", imc);

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
{
    pesoIdeal = 18.5 * altura * altura;
    double ganharPeso = Math.Round((peso - pesoIdeal), 2);
    Console.WriteLine("Para chegar à situação ideal, você deve ganhar {0} kg.", ganharPeso);
}

else if (imc > 25)
{
    pesoIdeal = 24.9 * altura * altura;
    double perderPeso = Math.Round((peso - pesoIdeal), 2);
    Console.WriteLine("Para chegar à situação ideal, você deve perder {0} kg.", perderPeso);

}
