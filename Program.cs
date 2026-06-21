namespace petshope.primary;
using petshope.primary;

public class Program
{
    public static void Main()
    {
    Console.WriteLine("Bem-vindo ao Petshope!");
    Sistema  sistema = new Sistema();
    switch (Console.ReadLine())
    {
        case "1":
            sistema.adicionardono();
            break;
        case "2":
            sistema.adicionarpet();
            break;
        case "3":
            Veterinario.Horariosdeatendimento();
            sistema.criarconsulta();
            break;
            
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
    }
}
