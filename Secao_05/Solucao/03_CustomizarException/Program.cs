using _03_CustomizarException;

try
{
    throw new MinhaException("10");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
