namespace petshope.primary;

public class Pet
{
    public string Nome { get; }
    public string TipoAnimal { get; }
    public int Idade { get; }
    public Dono Dono { get; }

    public Pet(string nome, string tipoanimal, int idade, Dono dono)
    {
        Nome = nome;
        TipoAnimal = tipoanimal;
        Idade = idade;
        Dono = dono;

    }
}
   
