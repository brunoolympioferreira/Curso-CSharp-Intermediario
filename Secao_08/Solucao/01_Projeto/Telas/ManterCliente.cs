using _01_Projeto.Conversores;
using Biblioteca.Arquivo;
using Biblioteca.Model;

namespace _01_Projeto.Telas;
public class ManterCliente
{
    public void CadastrarCliente()
    {
        Cliente cliente = new();

        Console.Clear();

        Console.WriteLine("CADASTRAR CLIENTE");

        Console.Write("Nome: ");
        cliente.Nome = Console.ReadLine();

        Console.Write("Data de Nascimento: ");
        cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

        Console.Write("Telefone: ");
        cliente.Telefone = Console.ReadLine();

        Console.Write("CPF: ");
        cliente.CPF = Console.ReadLine();

        Console.Write("RG: ");
        cliente.RG = Console.ReadLine();

        Console.Write("CEP(Digitar apenas números): ");
        cliente.CEP = int.Parse(Console.ReadLine());

        Console.Write("Estado: ");
        cliente.Estado = Console.ReadLine();

        Console.Write("Cidade: ");
        cliente.Cidade = Console.ReadLine();

        Console.Write("Endereço: ");
        cliente.Endereco = Console.ReadLine();

        GerenciadorArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));
    }

    public void ListarClientes()
    {
        Console.Clear();

        Console.WriteLine("LISTAGEM DE CLIENTES");

        string[] linhas = GerenciadorArquivo.LerArquivo("cliente");

        foreach (string linha in linhas)
        {
            Cliente cliente = ClienteTexto.ConvertarParaCliente(linha);
            Console.WriteLine("Nome: " + cliente.Nome);
        }
    }
}
