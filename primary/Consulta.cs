using Microsoft.VisualBasic;

namespace petshope.primary;


public class Consulta
{
    public Pet Pet { get; set; }
    public Dono Dono { get; set; }
    public Veterinario Veterianario { get; set; }
   

    public Consulta(Pet pet, Dono dono, Veterinario veterinario)
    {
        this.Pet = pet;
        this.Dono = dono;
        this.Veterianario = veterinario;
    }

  
}