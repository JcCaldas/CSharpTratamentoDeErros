Console.WriteLine("Tratamento de Erros\n");
/*É sempre bom prevenir os erros*/

try
{

    Console.WriteLine("Informe o dividento:");
    int dividento = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o divisor:");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividento / divisor);
    Console.WriteLine($"\n{dividento}/{divisor} = {resultado}");

}
//Tratando cada possível excessão
catch (FormatException ex)
{
    
    Console.WriteLine("\nInforme um valor inteiro");

}
catch (OverflowException)
{
    Console.WriteLine("\nInforme um valor inteiro entre 1 e 999999");
}
catch (DivideByZeroException)
{
    Console.WriteLine("\nNão existe divisão por zero, tente novamente");
}
catch (Exception ex)//Tratamento de excessão geral (sempre por último)
{

    Console.WriteLine($"\n{ex.GetType()} informa: {ex.Message}");//tipo de exceção e mensagem
    Console.WriteLine($"\n{ex.Message}");//mensagem
    Console.WriteLine($"\n{ex.Source}");//de onde veio a mensagem
    Console.WriteLine($"\n{ex.StackTrace}");//exibe a pilha de execução, mostrando onde ocorreu o erro, em qual classe e linha do código

}
