public class Individuo
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }

    public double IMC { get => Peso / (Altura*Altura);}
    public double GanharPeso { get => ((18.5 * Altura * Altura) - Peso);}
    public double PerderPeso { get => (Peso - (24.9 * Altura * Altura));}

    public string Classificacao
    {
        get
        {
            if (IMC < 17)
            {
                return "Muito abaixo do peso...";
            }

            else if (IMC <= 18.5)
            {
                return "Abaixo do peso...";
            }

            else if (IMC <= 24.9)
            {
                return "Peso normal!";
            }

            else if (IMC <= 29.9)
            {
                return "Acima do peso...";
            }

            else if (IMC <= 34.9)
            {
                return "Obesidade I...";
            }

            else if (IMC <= 39.9)
            {
                return "Obesidade II...";
            }

            else
            {
                return "Obesidade III...";
            }
        }
    }

    
        public Individuo(String nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }
    public Individuo()
    {
        Nome = "";
        Altura = 0;
        Peso = 0;
    }
}