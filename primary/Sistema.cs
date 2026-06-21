using System.Runtime.InteropServices;
using System.Security.Authentication;

namespace petshope.primary;

public class Sistema
{
    public List<Pet> Pets { get; set; } = new List<Pet>();
    public List<Dono> Donos { get; set; } = new List<Dono>();
    public List<Consulta> Consultas { get; set; } = new List<Consulta>();
    public List<Veterinario> Veterinarios {get; set;} =new List<Veterinario>();
  
    public Sistema(List<Pet> pets,List<Consulta> consultas,List<Dono> donos,List<Veterinario> veterinarios)
    {
        this.Pets = pets;
        this.Donos = donos;
        this.Consultas = consultas;
        this.Veterinarios = veterinarios;
    }
    public void Criarvet() 
    {
          Veterinario vet = new Veterinario("joao alberto oliveira",56798376609,"USJT veterinaria clinicas", new Dictionary<int, Pet?> {{9,null}, {8,null},{10,null},{12,null}});
          Veterinario vet2 = new Veterinario("pedro tadeu bertoline",87690078088,"UAM veterinaria e tecnicas de cuidado ao animal",new Dictionary<int, Pet?> {{11,null}, {14,null},{23,null},{12,null}});
    }
    public void criarconsulta(Consulta consulta, Pet pet, Veterinario veterinario, Dono dono)
    {
        foreach (var Pet in Pets)
        {
            Console.WriteLine($"Digite o nome do pet para criar a consulta");
            string nomepet = Console.ReadLine();
        }
       if (nomepet == pet.Name)
        {
            Console.WriteLine($"O pet {pet.Name} ja existe no sistema");
        }
        else
        {
            Console.WriteLine("qual e o tipo do animal?");
            string tipoanimal = Console.ReadLine();
            Console.WriteLine("qual e a idade do pet?");
            int idade = int.Parse(Console.ReadLine());
            foreach (var dono in Donos)
            {
                Console.WriteLine($"Digite o nome do dono ?");
                string nomedono = Console.ReadLine();
                if (nomedono == dono.Nome)
                {
                    Console.WriteLine($"O dono {dono.Nome} ja existe no sistema");
                }
                else
                {
                    Console.WriteLine($"Digite o telefone do dono ?");
                    string telefone = Console.ReadLine();
                    Console.WriteLine($"Digite o email do dono ?");
                    string email = Console.ReadLine();
                    Dono dononovo = new Dono(nomedono,telefone,email);
                    Pet petnovo = new Pet(nomepet,tipoanimal,idade,dononovo);
                    Pets.Add(petnovo);
                    Donos.Add(dononovo);
                    if (veterinario.Agenda.Count < 5)
                    {
                        Console.WriteLine($"Digite o horario para a consulta(ex:9,8,10):");
                        int horario = int.Parse(Console.ReadLine());
                        veterinario.verificadordeagenda(horario, petnovo);
                        Consulta consultanova = new Consulta(petnovo,dononovo,veterinario);
                        Consultas.Add(consultanova);
                    }
                    else
                    {
                        Console.WriteLine($"O veterinario {veterinario.Nome} ja tem 5 consultas agendadas tente outro veterinario");
                    }
                }
            }
            
        }
    }
}
