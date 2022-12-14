string texto = File.ReadAllText("C:\\Users\\Bruno\\Documents\\Cursos\\Curso-CSharp-Intermediario\\Secao_07\\Arquivo\\texto.txt");

Console.WriteLine(texto);

string[] linhas = File.ReadAllLines("C:\\Users\\Bruno\\Documents\\Cursos\\Curso-CSharp-Intermediario\\Secao_07\\Arquivo\\texto.txt");

Console.WriteLine("Quantidade Linhas: " + linhas.Length);

foreach (string linha in linhas)
{
    Console.WriteLine("Linha: " + linha);
}

Console.ReadKey();
