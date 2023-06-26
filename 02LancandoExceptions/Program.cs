Console.WriteLine("Lançando Exceções\n");


try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();
class A
{
    public static void ProcessarA()
    {
        //Se o tratamento está aqui, ele trata e não passa
        try
        {
            B.ProcessarB();
        }
        catch (Exception)
        {
            throw; //repassa a excessão para ser tratada
            Console.WriteLine("Tratando Erro em A");
        }
    }
}

class B
{
    public static void ProcessarB()
    {
        C.ProcessarC();
    }
}

class C
{
    public static void ProcessarC()
    {
        //lançando exceção manual
        throw new NotImplementedException("Método não implementado");
    }
}