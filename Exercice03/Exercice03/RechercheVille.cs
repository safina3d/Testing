using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice03;

public class RechercheVille
{
    private List<String> _villes;

    public List<String> Villes { get { return _villes; } }

    public RechercheVille(List<String> villes)
    {
        this._villes = villes;
    }
    

    public List<String> Rechercher(String mot)
    {
        if(mot == "*") return _villes;

        if (mot.Length < 2) throw new NotFoundException("Le nom de la ville doit contenir au moins 2 caractères");

        mot = mot.Trim().ToLower();
        var filteredCities = _villes.Where(city => city.Contains(mot)).ToList();
        return filteredCities;
    }


    


}
