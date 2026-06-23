namespace petshope.primary;
using petshope.primary;

public class Program
{
    public static void Main()
    {
    Console.WriteLine("Bem-vindo ao Petshope Camaleão!");
    Sistema  sistema = new Sistema(pets: new List<Pet>(), consultas: new List<Consulta>(), donos: new List<Dono>(), veterinarios: new List<Veterinario>());
    switch (Console.ReadLine())
    {
        case "1":
            sistema.adicionardono();
            break;
        case "2":
            sistema.adicionarpet();
            break;
        case "3":
            sistema.criarveterinario();
            break;
        case "4":
            Veterinario.Horariosdeatendimento();
            sistema.criarconsulta();
            break;

        
            
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
    }
}
