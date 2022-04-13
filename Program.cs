Individuo i1 = new Individuo();

Console.WriteLine("-----CALCULADORA IMC-----\n");

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

Console.WriteLine("\nClassificação do IMC: {0}", i1.Classificacao); 

