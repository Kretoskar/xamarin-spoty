using System;
using System.Collections.Generic;
using System.Text;

namespace Spoty.ModeI
{
    public class DummySpotsData
    {
        public List<Spot> Spots { get; set; }

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
            Spots.Add(new Spot
            {
                Name = "3 maja",
                Categories = SpotCategory.Ledges,
                Slug = "trzy_maja.jpg",
                ShortDesc = "Betonowe murki, dobry flat",
                LongDesc = "Betonowe murki z drewnianą ławką, kicker na końcu. Dobry flat",
                Latitude = 50.035935f,
                Longitude = 22.001026f
            });
            Spots.Add(new Spot
            {
                Name = "Pomnik Piłsudskiego",
                Categories = SpotCategory.Ledges,
                Slug = "pomnik_pilsudskiego.jpg",
                ShortDesc = "Marmurowy murek",
                LongDesc = "Marmurowy murek",
                Latitude = 50.039472f,
                Longitude = 22.008637f
            });
            Spots.Add(new Spot
            {
                Name = "Rura szpital lwowska",
                Categories = SpotCategory.Rails,
                Slug = "rura_szpital_lwowska.jpg",
                ShortDesc = "Długi handrail z niskim, płaskim początkiem",
                LongDesc = "Długi handrail z niskim, płskim początkiem.",
                Latitude = 50.036849f,
                Longitude = 22.033108f
            });
            Spots.Add(new Spot
            {
                Name = "Metalowa ławka Hartbex",
                Categories = SpotCategory.Ledges,
                Slug = "metalowa_lawka_hartbex.jpg",
                ShortDesc = "Metalowa ławka",
                LongDesc = "Metalowa ławka.",
                Latitude = 50.029641f,
                Longitude = 22.008239f
            });
            //Odrzykońska 9 curb
            Spots.Add(new Spot
            {
                Name = "Łamany murek",
                Categories = SpotCategory.Ledges,
                Slug = "lamany_murek.jpg",
                ShortDesc = "Długi, łamany murek",
                LongDesc = "Długi, łamany murek z dużym nachyleniem. Najazd i odjazd z kostki",
                Latitude = 50.048518f,
                Longitude = 21.978455f
            });
            Spots.Add(new Spot
            {
                Name = "Murek UR",
                Categories = SpotCategory.Ledges,
                Slug = "murek_ur.jpg",
                ShortDesc = "Betonowy murek",
                LongDesc = "Betonowy murek, nawierzchnia - kostka.",
                Latitude = 50.036594f,
                Longitude = 22.038512f
            });
            Spots.Add(new Spot
            {
                Name = "Frac murek w górę",
                Categories = SpotCategory.Ledges,
                Slug = "frac_murek_w_gore.jpg",
                ShortDesc = "Murek z aluminiowym kątownikiem.",
                LongDesc = "Murek w górę z aluminiowym, wgniatjącym się kątownikiem.",
                Latitude = 50.020975f,
                Longitude = 22.010955f
            });
            //Bazarek przy placu wolności
            Spots.Add(new Spot
            {
                Name = "Nowy świat gap",
                Categories = SpotCategory.Gaps,
                Slug = "nowy_swiat_gap.jpg",
                ShortDesc = "Gap z dachu jakiejś budy.",
                LongDesc = "Gap z dachu jakiejś budy. Skok nad railem, odjazd na kostkę",
                Latitude = 50.048944f,
                Longitude = 21.977767f
            });
            Spots.Add(new Spot
            {
                Name = "Łamany murek Odrzykońska",
                Categories = SpotCategory.Ledges,
                Slug = "lamany_murek_odrzykonska.jpg",
                ShortDesc = "Harpagan murek.",
                LongDesc = "Hapagański murek, najazd i odjazd - kostka.",
                Latitude = 50.046953f,
                Longitude = 21.951428f
            });
            Spots.Add(new Spot
            {
                Name = "Teatr maska",
                Categories = SpotCategory.Ledges,
                Slug = "teatr_maska.jpg",
                ShortDesc = "Murek przy teatrze maska.",
                LongDesc = "Murek przy teatrze maska, najazd i odjazd - kostka.",
                Latitude = 50.037875f,
                Longitude = 22.006822f
            });
            Spots.Add(new Spot
            {
                Name = "Wydział muzyki UR",
                Categories = SpotCategory.Gaps,
                Slug = "wydzial_muzyki_ur.jpg",
                ShortDesc = "Schodki, gapy, murki.",
                LongDesc = "Schodki, gapy, wysokie handraile i niskie murki",
                Latitude = 50.022950f,
                Longitude = 21.986143f
            });

        }
    }
}