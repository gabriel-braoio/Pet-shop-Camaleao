using Microsoft.VisualBasic;

namespace petshope.primary;


public class Consulta
{
    public Pet Pet { get; set; }
    public Dono Dono { get; set; }
    public Veterinario Veterianario { get; set; }
    public int dataconsulta { get; set; }
   

    public Consulta(Pet pet, Dono dono, Veterinario veterinario, int dataconsulta)
    {
        this.Pet = pet;
        this.Dono = dono;
        this.Veterianario = veterinario;
        this.dataconsulta = dataconsulta;
    }
  
}