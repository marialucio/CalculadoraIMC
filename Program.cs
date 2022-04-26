Individuo i1 = new Individuo();

Console.WriteLine("-----CALCULADORA IMC-----");

Console.WriteLine("Informe seu nome:");
i1.Nome = Console.ReadLine();

Console.WriteLine("Informe sua altura:");
i1.Altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Informe seu peso:");
i1.Peso = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("\n~~~~\n");

Console.WriteLine("Nome: {0}", i1.Nome);
Console.WriteLine("Altura: {0}", i1.Altura);
Console.WriteLine("Peso: {0}", i1.Peso);
Console.WriteLine("IMC: {0}", Math.Round(i1.IMC, 2));

Console.WriteLine("\nClassificação do IMC: {0}", i1.Classificacao);

if(i1.IMC < 18.5)
{
    Console.WriteLine("\nPara chegar ao seu peso ideal, você deve ganhar {0} kg", Math.Round(i1.GanharPeso, 2));
}

if(i1.IMC > 24.9)
{
    Console.WriteLine("\nPara chegar ao seu peso ideal, você deve perder {0} kg", Math.Round(i1.PerderPeso, 2));
}