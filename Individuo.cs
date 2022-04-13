public class Individuo
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }

    public double IMC { get => Peso / (Altura*Altura);}

    public Individuo()
    {
        Nome = "";
        Altura = 0;
        Peso = 0;
    }


    public string Classificacao
    {
        get
        {
            if (IMC < 17)
            {
                return "Muito abaixo do peso...";
            }

            else if (IMC >= 17 && IMC < 18.5)
            {
                return "Abaixo do peso...";
            }

            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                return "Peso normal!";
            }

            else if (IMC >= 25 && IMC <= 29.9)
            {
                return "Acima do peso...";
            }

            else if (IMC >= 30 && IMC <= 34.9)
            {
                return "Obesidade I...";
            }

            else if (IMC >= 35 && IMC <= 39.9)
            {
                return "Obesidade II...";
            }

            else
            {
                return "Obesidade III...";
            }
        }
    }

    public void PesoIdeal()
    {
        if(IMC < 18.5)
        {
            double pesoIdeal = 18.5 * Altura * Altura;
            double ganharPeso = Math.Round((Peso - pesoIdeal), 2);

        }

        if(IMC > 24.9)
        {
            double pesoIdeal = 24.9 * Altura * Altura;
            double perderPeso = Math.Round((Peso - pesoIdeal), 2);
        }
    }
}