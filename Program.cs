namespace petshope.primary;
using petshope.primary;

public class Program
{
    public static void Main()
    {
    Console.WriteLine("Bem-vindo ao Petshope Camaleão!");
    Sistema  sistema = new Sistema(pets: new List<Pet>(), consultas: new List<Consulta>(), donos: new List<Dono>(), veterinarios: new List<Veterinario>());
    Console.WriteLine("menu de opções:");
    Console.WriteLine("1. Adicionar Dono");
    Console.WriteLine("2. Adicionar Pet");
    Console.WriteLine("3. Criar Veterinário");
    Console.WriteLine("4. Criar Consulta");
    Console.WriteLine("5. Listar Consultas");
    Console.WriteLine("6. Listar Veterinários");
    Console.WriteLine("7. Listar Pets");
    Console.WriteLine("8. Listar Donos");
    sistema.Menu();
    }
}
