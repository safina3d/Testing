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

    [TestMethod]
    public void WhenRechercher_AtLeast2Chars_ThenReturnsAllCitiesStatingWith()
    {
        Setup();
        string word = "Va";
        var result = _rechercheVille?.Rechercher(word).All(city => city.StartsWith(word));
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void WhenRechercher_IsNotCaseSensitive()
    {
        Setup();
        CollectionAssert.AreEquivalent(
            _rechercheVille?.Rechercher("Va"), 
            _rechercheVille?.Rechercher("va")            
        );
    }

    [TestMethod]
    public void WhenRechercher_WithSubstring()
    {
        Setup();
        Assert.IsNotEmpty(_rechercheVille?.Rechercher("ape"));
    }
    
    [TestMethod]
    public void WhenRechercher_WithWildcardCharacter_ThenReturnsAllCities()
    {
        Setup();
        CollectionAssert.AreEquivalent(_rechercheVille?.Villes, _rechercheVille?.Rechercher("*"));
    }
}
