public class Individuo
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }

    public double IMC { get => (Math.Round(Peso / (Altura*Altura), 2);}

    public Individuo(string nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public double GanharPeso()
    {
        double pesoIdeal = 18.5 * Altura * Altura;
        double ganharPeso = Math.Round((Peso - pesoIdeal), 2);
        return ganharPeso;
    }

    public double PerderPeso()
    {
        double pesoIdeal = 24.9 * Altura * Altura;
        double perderPeso = Math.Round((Peso - pesoIdeal), 2);
        return perderPeso;
    }




}