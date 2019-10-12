using System;
using System.Collections.Generic;
using System.Text;

namespace Spoty.ModeI
{
    public class DummySpotsData
    {
        public List<Spot> Spots { get; set; }
        //public List<Spot> Gaps
        //{
        //    get
        //    {
        //        List<Spot> gaps = new List<Spot>();
        //        foreach (Spot spot in Spots)
        //        {
        //            if(spot.Categories.Contains(SpotCategory.Ledges))
        //            {
        //                gaps.Add(spot);
        //            }
        //        }
        //        return gaps;
        //    }
        //}
        //public List<Spot> Ledges
        //{
        //    get
        //    {
        //        List<Spot> ledges = new List<Spot>();
        //        foreach (Spot spot in Spots)
        //        {
        //            if (spot.Categories.Contains(SpotCategory.Ledges))
        //            {
        //                ledges.Add(spot);
        //            }
        //        }
        //        return ledges;
        //    }
        //}
        //public List<Spot> Rails
        //{
        //    get
        //    {
        //        List<Spot> rails = new List<Spot>();
        //        foreach (Spot spot in Spots)
        //        {
        //            if (spot.Categories.Contains(SpotCategory.Rails))
        //            {
        //                rails.Add(spot);
        //            }
        //        }
        //        return rails;
        //    }
        //}
        //public List<Spot> Others
        //{
        //    get
        //    {
        //        List<Spot> others = new List<Spot>();
        //        foreach (Spot spot in Spots)
        //        {
        //            if (spot.Categories.Contains(SpotCategory.Others))
        //            {
        //                others.Add(spot);
        //            }
        //        }
        //        return others;
        //    }
        //}

        public DummySpotsData()
        {
            Spots = new List<Spot>();
            Spots.Add(new Spot
            {
                Name = "Pomnik mickiewicza",
                Categories = SpotCategory.Gaps,
                Slug = "pomnik_mickiewicza.jpg",
                ShortDesc = "Schody, krawężniki i murek",
                LongDesc = "Schody 1- 4, nawoskowany krawężnik i marmurowy murek. Nawierzchnia - marmurowe płyty",
                Latitude = 50.0374781f,
                Longitude = 22.0090554999999f
            });
            Spots.Add(new Spot
            {
                Name = "Niebieska siódemka",
                Categories = SpotCategory.Gaps,
                Slug = "niebieska_siodemka.jpg",
                ShortDesc = "7 schodów, handrail z dużym nachyleniem",
                LongDesc = "7 schodów, najazd z płytek, odjazd na kostkę. Handrail z dużym nachyleniem.",
                Latitude = 50.042335f,
                Longitude = 21.993306f
            });
            Spots.Add(new Spot
            {
                Name = "Handrail Krakowska",
                Categories = SpotCategory.Rails,
                Slug = "handrail_krakowska.jpg",
                ShortDesc = "Handrail z możliwością naskoku od boku.",
                LongDesc = "Handrail z możliwością naskoku od boku.",
                Latitude = 50.045358f,
                Longitude = 21.983674f
            });
            Spots.Add(new Spot
            {
                Name = "Park inwalidów wojennych",
                Categories = SpotCategory.Others,
                Slug = "park_inwalidow_wojennych.jpg",
                ShortDesc = "Betonowe fale, hubby",
                LongDesc = "Betonowe, wąskie fale. Hubby na obie strony z najazdem z kostki.",
                Latitude = 50.022063f,
                Longitude = 21.987076f
            });

        }
    }
}