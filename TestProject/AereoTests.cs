using CompanyService;

namespace TestProject;

public class AereoTests
{
    [Fact]
    public void VerificaInizializzazioneId()
    {
        // ARRANGE
        int idAreeo = 1;
        string codiceAereo = "ABCDEF";

        // ACT
        var aereo = new Aereo(idAreeo, codiceAereo);

        // ASSERT
        Assert.Equal(idAreeo, aereo.IdAereo);
        Assert.Equal(codiceAereo, aereo.CodiceAereo);
    }
}
