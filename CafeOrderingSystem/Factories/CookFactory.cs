using CafeOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingSystem.Factories
{
    public static class CookFactory
    {
        public static List<Cook> CreateCookTeam(params string[] names)
        {
            return names.Select(names => new Cook(names)).ToList();
        }
    }
}
