using _01_Projeto.Telas;

int opcoes = 0;
while (opcoes != 5)
{
    Console.WriteLine("O que deseja fazer? \n(1 = Cadastrar Cliente, 2 = Listar Cliente, 3 = Cadastrar Funcionario, 4 = Listar Funcionario, 5 = Fechar)");
	
	opcoes = int.Parse(Console.ReadLine());

    ManterCliente telaCliente = new();
	ManterFuncionario telaFuncionario = new();

    switch (opcoes)
	{
		case 1:
			telaCliente.CadastrarCliente();
			break;
		case 2:
			telaCliente.ListarClientes();
            break;
		case 3:
			telaFuncionario.CadastrarFuncionario();
			break;
		case 4:
			telaFuncionario.ListarFuncionarios();
			break;
		case 5:
			break;
		default:
			Console.WriteLine("Comando não encontrado!");
			break;
	}
}

