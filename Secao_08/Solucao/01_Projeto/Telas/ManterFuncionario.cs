using _01_Projeto.Conversores;
using Biblioteca.Arquivo;
using Biblioteca.Model;

namespace _01_Projeto.Telas;
public class ManterFuncionario
{
    public void CadastrarFuncionario()
    {
        Funcionario funcionario = new();

        Console.Clear();

        Console.WriteLine("CADASTRAR FUNCIONARIO");

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();

        Console.Write("Data de Nascimento: ");
        funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

        Console.Write("Telefone: ");
        funcionario.Telefone = Console.ReadLine();

        Console.Write("CPF: ");
        funcionario.CPF = Console.ReadLine();

        Console.Write("RG: ");
        funcionario.RG = Console.ReadLine();

        Console.Write("CEP(Digitar apenas números): ");
        funcionario.CEP = int.Parse(Console.ReadLine());

        Console.Write("Estado: ");
        funcionario.Estado = Console.ReadLine();

        Console.Write("Cidade: ");
        funcionario.Cidade = Console.ReadLine();

        Console.Write("Endereço: ");
        funcionario.Endereco = Console.ReadLine();

        Console.Write("Cargo: ");
        funcionario.Cargo = Console.ReadLine();

        Console.Write("Salario: ");
        funcionario.Salario = double.Parse(Console.ReadLine());

        Console.Write("Data Contratacao: ");
        funcionario.DataContratacao =  DateTime.Parse(Console.ReadLine());

        GerenciadorArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));

    }

    public void ListarFuncionarios()
    {
        Console.Clear();

        Console.WriteLine("LISTAGEM DE FUNCIONARIOS");

        string[] linhas = GerenciadorArquivo.LerArquivo("funcionario");

        foreach (string linha in linhas)
        {
            Funcionario funcionario = FuncionarioTexto.ConvertarParaFuncionario(linha);
            Console.WriteLine("Nome: " + funcionario.Nome + " Cargo: " + funcionario.Cargo);
        }
    }
}
