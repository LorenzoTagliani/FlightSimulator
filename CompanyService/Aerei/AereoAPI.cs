namespace CompanyService;

public class AereoAPI
{
    public int IdAereo { get; set; }
    public string CodiceAereo { get; set; }
    
    public AereoAPI(int idAereo, string codiceAereo)
    {
        IdAereo = idAereo;
        CodiceAereo = codiceAereo;
    }
}
