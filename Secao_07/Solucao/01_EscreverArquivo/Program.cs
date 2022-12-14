StreamWriter arquivo = new StreamWriter("C:\\Users\\Bruno\\Documents\\Cursos\\Curso-CSharp-Intermediario\\Secao_07\\Arquivo\\texto.txt");

arquivo.WriteLine("Olá este é o meu primeiro arquivo");
arquivo.WriteLine("Bem vindo ao ano 2022 \n Desejo o melhor ano das suas vidas");

arquivo.Close();

Console.WriteLine("Arquivo gravado!");

Console.ReadKey();
