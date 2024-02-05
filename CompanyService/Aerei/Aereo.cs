namespace CompanyService;

public class Aereo
{
    public int IdAereo { get; set; }
    public string CodiceAereo { get; set; }
    
    public Aereo(int idAereo, string codiceAereo)
    {
        IdAereo = idAereo;
        CodiceAereo = codiceAereo;
    }
}
