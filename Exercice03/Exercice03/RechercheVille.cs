using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice03;

public class RechercheVille
{
    private List<String> _villes = new List<String>() {
        "Paris", "Budapest", "Skopje", "Rotterdam", "Valence",
        "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", 
        "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
    };

    public List<String> Rechercher(String mot)
    {
        if (mot.Length < 2) throw new NotFoundException("Le nom de la ville doit contenir au moins 2 caractères");

        mot = mot.Trim().ToLower();
        var filteredCities = _villes.Where(city => city.StartsWith(mot)).ToList();
        return filteredCities;
    }


}
