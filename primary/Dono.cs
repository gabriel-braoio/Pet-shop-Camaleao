namespace petshope.primary;

public class Dono
{
    public string? Nome { get; }
    public string? Telefone { get; }
    public string? Email { get; }
    public List<Pet>? Animais { get; }

    public Dono(string nome, string telefone, string email)
    {
        this.Nome = nome;
        this.Telefone = telefone;
        this.Email = email;
        this.Animais = new List<Pet>();

    }

    public void Addanimal(Pet pet)
    {
        Animais.Add(pet);
    }
}
