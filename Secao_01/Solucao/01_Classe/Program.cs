using _01_Classe;

Pessoa pessoa = new Pessoa();
pessoa.Nome = "José Costa";
pessoa.Sexo = "M";
pessoa.DataNascimento = new DateTime(1974, 10, 3);

string texto = pessoa.ResumoPessoa();

Console.Write(texto);

Console.ReadKey();