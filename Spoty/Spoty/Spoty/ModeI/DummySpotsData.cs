using System;
using System.Collections.Generic;
using System.Text;

namespace Spoty.ModeI
{
    class DummySpotsData
    {
        public List<Spot> spots;

        public DummySpotsData()
        {
            spots.Add(new Spot("Pomnik mickiewicza", 
                               new List<SpotCategory>() { SpotCategory.Gaps, SpotCategory.Ledges },
                               "pomnik_mickiewicza", 
                               "Schody, krawężniki i murek", 
                               "Schody 1- 4, nawoskowany krawężnik i marmurowy murek. Nawierzchnia - marmurowe płyty",
                               50.0374781f,
                               22.0090554999999f));
            spots.Add(new Spot("Niebieska siódemka", 
                               new List<SpotCategory>() { SpotCategory.Gaps },
                               "niebieska_siodemka", 
                               "7 schodów, handrail z dużym nachyleniem", 
                               "7 schodów, najazd z płytek, odjazd na kostkę. Handrail z dużym nachyleniem.",
                               50.042335f,
                               21.993306f));
            spots.Add(new Spot("Handrail Krakowska", 
                               new List<SpotCategory>() { SpotCategory.Rails },
                               "handrail_krakowska", 
                               "Handrail z możliwością naskoku od boku.", 
                               "Handrail z możliwośćią naskoku od boku.",
                               50.045358f,
                               21.983674f));
            spots.Add(new Spot("Park inwalidów wojennych", 
                               new List<SpotCategory>() { SpotCategory.Ledges, SpotCategory.Others },
                               "park_inwalidow_wojennych", 
                               "Betonowe fale, hubby", 
                               "Betonowe, wąskie fale. Hubby na obie strony z najazdem z kostki.",
                               50.022063f,
                               21.987076f));
                    
        }
    }
}