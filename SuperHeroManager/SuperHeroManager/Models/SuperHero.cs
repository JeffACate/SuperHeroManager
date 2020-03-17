using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroManager.Models
{
    public class SuperHero
    {
        public int SuperHeroId { get; set; }
        public string name { get; set; }
        public string universe { get; set; }
        public string alterEgo { get; set; }
        public string primaryAbility { get; set; }
        public string secondaryAbility { get; set; }
        public string catchPhrase { get; set; }
    }
}
