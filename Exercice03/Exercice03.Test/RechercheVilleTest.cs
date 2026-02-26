namespace Exercice03.Test;

[TestClass]
public class RechercheVilleTest
{
    private RechercheVille? _rechercheVille;
    
    public void Setup()
    {
        _rechercheVille = new RechercheVille();
    }

    [TestMethod]
    public void WhenRechercher_WithLessThan2Chars_ThenException()
    {
        Setup();
        Assert.Throws<NotFoundException>(() => _rechercheVille?.Rechercher("A"));
    }



}
