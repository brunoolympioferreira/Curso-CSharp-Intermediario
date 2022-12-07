namespace _01_ClasseInterna;

class Pessoa
{
    void GetOlhos()
    {
        Olho olho = new Olho();
    }
    public class Olho
    {
        public static string Iris = "XXX";
        public Olho()
        {
            Pessoa pessoa = new Pessoa();
        }
    }
}
