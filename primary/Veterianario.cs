using System.Linq;
using System.Runtime;
using System.Security.Cryptography;

namespace petshope.primary;

public class Veterinario
{
    public string Nome { get; set; }
    public double Cpf { get; set; }
    public string Formacao { get; set; }
    public Dictionary<int, Pet?> Agenda { get; set; }


    public Veterinario(string nome, double cpf, string formacao, Dictionary<int, Pet?> agenda)
    {
        this.Agenda = agenda;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Formacao = formacao;

    }

    public void verificadordeagenda(int horario, Pet pet)
    {
        if (Agenda.Count < 5)
        {
            if (Agenda.ContainsKey(horario) || Agenda.ContainsValue(pet))
            {
                Console.WriteLine($"O veterianario {Nome} ja tem um agendamento nesse horario ou para esse pet tente outro");
            }
            else
            {
                Agenda.Add(horario, pet);
                Console.WriteLine($"foi feito um agendamento para esse {horario} e para esse {pet}");
            }
        }

    }

    public static void Horariosdeatendimento()
    {
        Console.WriteLine("Horários de atendimento: 8h - 17h");
        Console.WriteLine("Horários disponíveis: 8, 9, 10, 11, 12, 14, 15, 16, 17");
    }
}