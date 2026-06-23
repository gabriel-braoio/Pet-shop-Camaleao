using System.Runtime.InteropServices;
using System.Security.Authentication;

namespace petshope.primary;

public class Sistema
{
    public List<Pet> Pets { get; set; } = new List<Pet>();
    public List<Dono> Donos { get; set; } = new List<Dono>();
    public List<Consulta> Consultas { get; set; } = new List<Consulta>();
    public List<Veterinario> Veterinarios { get; set; } = new List<Veterinario>();

    public Sistema(List<Pet> pets, List<Consulta> consultas, List<Dono> donos, List<Veterinario> veterinarios)
    {
        this.Pets = pets;
        this.Donos = donos;
        this.Consultas = consultas;
        this.Veterinarios = veterinarios;
    }

    string nomepet;
    string nomeDono;
    string nomeveterinario;
    int dataconsulta;

    public bool existenosistema(string nomepet, string nomeDono, string nomeveterinario)
    {
        bool donoexiste = !string.IsNullOrEmpty(nomeDono) && Donos.Any(d => d.Nome == nomeDono);
        bool petexiste = !string.IsNullOrEmpty(nomepet) && Pets.Any(p => p.Nome == nomepet);
        bool veterinarioexiste = !string.IsNullOrEmpty(nomeveterinario) && Veterinarios.Any(v => v.Nome == nomeveterinario);
        bool consultaexiste = Consultas.Any(c => c.dataconsulta == dataconsulta);

        return donoexiste || petexiste || veterinarioexiste || consultaexiste;
    }

    public void adicionardono()
    {
        Console.WriteLine("Digite o nome do dono:");
        string nomeDono = Console.ReadLine();
        if (existenosistema(null, nomeDono, null))
        {
            Console.WriteLine("Esse dono já existe no sistema, tente outro nome");
        }
        else
        {
            Console.WriteLine("Digite o telefone do dono:");
            string telefone = Console.ReadLine();
            Console.WriteLine("Digite o email do dono:");
            string email = Console.ReadLine();
            Dono dono = new Dono(nomeDono, telefone, email);
            Donos.Add(dono);
            Console.WriteLine($"O dono {nomeDono} foi adicionado ao sistema com sucesso!");
        }
    }

    public void adicionarpet()
    {
        Console.WriteLine("Digite o nome do pet:");
        string nomepet = Console.ReadLine();
        if (existenosistema(nomepet, null, null))
        {
            Console.WriteLine("Esse pet já existe no sistema, tente outro nome");
        }
        else
        {
            Console.WriteLine("Digite o tipo do animal:");
            string tipoanimal = Console.ReadLine();
            Console.WriteLine("Digite a idade do pet:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do dono do pet:");
            string nomeDono = Console.ReadLine();
            Dono dono = Donos.FirstOrDefault(d => d.Nome == nomeDono);
            if (dono != null)
            {
                Pet pet = new Pet(nomepet, tipoanimal, idade, dono);
                Pets.Add(pet);
                Console.WriteLine($"O pet {nomepet} foi adicionado ao sistema com sucesso!");
            }
            else
            {
                Console.WriteLine($"O dono {nomeDono} não foi encontrado no sistema. Por favor, adicione o dono antes de adicionar o pet.");
            }
        }
    }

    public void criarveterinario()
    {
        Console.WriteLine("Digite o nome do veterinario:");
        string nomeveterinario = Console.ReadLine();
        if (existenosistema(null, null, nomeveterinario))
        {
            Console.WriteLine("Esse veterinario já existe no sistema, tente outro nome");
        }
        else
        {
            Console.WriteLine("Digite o cpf do veterinario:");
            double cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a formação do veterinario:");
            string formacao = Console.ReadLine();
            Dictionary<int, Pet?> agenda = new Dictionary<int, Pet?>();
            Veterinario veterinario = new Veterinario(nomeveterinario, cpf, formacao, agenda);
            Veterinarios.Add(veterinario);
            Console.WriteLine($"O veterinario {nomeveterinario} foi adicionado ao sistema com sucesso!");
        }
    }

    public void criarconsulta()
    {
        Console.WriteLine("Digite o nome do pet:");
        string nomepet = Console.ReadLine();
        Pet pet = Pets.FirstOrDefault(p => p.Nome == nomepet);
        if (pet == null)
        {
            Console.WriteLine($"O pet {nomepet} não foi encontrado no sistema. Por favor, adicione o pet antes de criar a consulta.");
            return;
        }
        else
        {
            Console.WriteLine("Digite o nome do dono:");
            string nomeDono = Console.ReadLine();
            Dono dono = Donos.FirstOrDefault(d => d.Nome == nomeDono);
            if (dono == null)
            {
                Console.WriteLine($"O dono {nomeDono} não foi encontrado no sistema. Por favor, adicione o dono antes de criar a consulta.");
                return;
            }
            Console.WriteLine("Digite o nome do veterinario:");
            string nomeveterinario = Console.ReadLine();
            Veterinario veterinario = Veterinarios.FirstOrDefault(v => v.Nome == nomeveterinario);
            if (nomeveterinario == null)
            {
                Console.WriteLine($"O veterinario {nomeveterinario} não foi encontrado no sistema. Por favor, adicione o veterinario antes de criar a consulta.");
                return;
            }

            Veterinario.Horariosdeatendimento();
            Console.WriteLine("Digite a hora da sua consulta (formato e 24h nao aceitando os minutos so as horas Ex: 13,12,19):");
            int dataconsulta = int.Parse(Console.ReadLine());
            veterinario.verificadordeagenda(dataconsulta, pet);
            Consulta consulta = new Consulta(pet, dono, veterinario, dataconsulta);
            Consultas.Add(consulta);
            Console.WriteLine($"A consulta para o pet {nomepet} com o veterinario {nomeveterinario} foi agendada com sucesso para o dia {dataconsulta}h!");
        }
    }


    public void listardonos()
    {
        if (Consultas.Count == 0)
        {
            Console.WriteLine("Não há donos cadastrados.");
            return; 
        }
        Console.WriteLine("Lista de donos cadastrados:");
        foreach (var dono in Donos)
        {
            Console.WriteLine($"Nome: {dono.Nome}, Telefone: {dono.Telefone}, Email: {dono.Email}");
        }
    }

    public void listarveterinarios()
    {
        if (Veterinarios.Count == 0) {
            Console.WriteLine("Não há veterinários cadastrados.");
            return;
        }
        Console.WriteLine("Lista de veterinários cadastrados:");
        foreach (var veterinario in Veterinarios)
        {
            Console.WriteLine($"Nome: {veterinario.Nome}, CPF: {veterinario.Cpf}, Formação: {veterinario.Formacao}");
        }
    }

    public void listarpets()
    {
        if (Pets.Count == 0) {
            Console.WriteLine("Não há pets cadastrados.");
            return;
        }
        Console.WriteLine("Lista de pets cadastrados:");
        foreach (var pet in Pets)
        {
            Console.WriteLine($"Nome: {pet.Nome}, Espécie: {pet.TipoAnimal}, Idade: {pet.Idade}");
        }
    }
    public void listarconsultas()
    {
        if (Consultas.Count == 0)
        {
            Console.WriteLine("Não há consultas agendadas.");
            return;
        }
        Console.WriteLine("Lista de consultas agendadas:");
        foreach (var consulta in Consultas)
        {
            Console.WriteLine($"Pet: {consulta.Pet.Nome}, Dono: {consulta.Dono.Nome}, Veterinário: {consulta.Veterianario.Nome}, Hora: {consulta.dataconsulta}");
        }
    }
    public void Menu()
    {
        Console.WriteLine("Escolha uma opção (1-8):");

        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                adicionardono();
                Menu();
                break;
            case 2:
                adicionarpet();
                Menu(); 
                break;
            case 3:
                criarveterinario();
                Menu();
                break;
            case 4:
                Veterinario.Horariosdeatendimento();
                criarconsulta();
                Menu();
                break;
            case 5:
                listarconsultas();
                Menu();
                break;
            case 6:
                listarveterinarios();
                Menu();
                break;
            case 7:
                listarpets();
                Menu();
                break;
            case 8:
                listardonos();
                Menu();
                break;



            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                break;
        }
    }




}
  














