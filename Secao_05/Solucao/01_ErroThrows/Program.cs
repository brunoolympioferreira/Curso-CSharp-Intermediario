Console.Write("Digite o Número 1: ");
string digitado = Console.ReadLine();

if (digitado == "1")
{
    Console.Write("Correto");
}
else
{
    throw new Exception("O valor digitado não é válido");
    Console.Write("Errado");
}

Console.ReadKey();

