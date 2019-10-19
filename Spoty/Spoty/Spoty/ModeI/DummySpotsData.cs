using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
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
                ShortDesc = "7 schodów, handrail",
                LongDesc = "7 schodów, najazd z płytek, odjazd na kostkę. Handrail z dużym nachyleniem.",
                Latitude = 50.042335f,
                Longitude = 21.993306f
            });
            Spots.Add(new Spot
            {
                Name = "Handrail Krakowska",
                Categories = SpotCategory.Rails,
                Slug = "handrail_krakowska.jpg",
                ShortDesc = "Handrail.",
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
                ShortDesc = "Długi handrail",
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
            Spots.Add(new Spot
            {
                Name = "Fontanna przy wydziale muzyki",
                Categories = SpotCategory.Ledges,
                Slug = "fontanna_przy_wydziale_muzyki.jpg",
                ShortDesc = "Kręcony manual pad, murek.",
                LongDesc = "Kręcony manual pad, murek",
                Latitude = 50.023118f,
                Longitude = 21.985947f
            });
            Spots.Add(new Spot
            {
                Name = "Curby przy fracu",
                Categories = SpotCategory.Ledges,
                Slug = "curby_przy_fracu.jpg",
                ShortDesc = "Krawężniki",
                LongDesc = "Krawężniki, małe mureczki",
                Latitude = 50.036590f,
                Longitude = 22.022161f
            });
            Spots.Add(new Spot
            {
                Name = "Estrada rail",
                Categories = SpotCategory.Rails,
                Slug = "estrada_rail.jpg",
                ShortDesc = "Rail na przypale",
                LongDesc = "Szkło z kątownikiem",
                Latitude = 50.037653f,
                Longitude = 22.003856f
            });
            Spots.Add(new Spot
            {
                Name = "Marcel curb",
                Categories = SpotCategory.Ledges,
                Slug = "marcel_curb.jpg",
                ShortDesc = "Curb z najazdem",
                LongDesc = "Curb z najazdem/zjazdem przy parkingu autobusów",
                Latitude = 50.041045f,
                Longitude = 22.004407f
            });
            Spots.Add(new Spot
            {
                Name = "Grube raile Biedronka",
                Categories = SpotCategory.Rails,
                Slug = "grube_raile_biedronka.jpg",
                ShortDesc = "Grube raile",
                LongDesc = "Grube raile z zakrętami przy końcach",
                Latitude = 50.044736f,
                Longitude = 21.955498f
            });
            Spots.Add(new Spot
            {
                Name = "Drzewo do backflipów",
                Categories = SpotCategory.Others,
                Slug = "drzewo_do_backflipow.jpg",
                ShortDesc = "Niech ktoś to zrobi",
                LongDesc = "Heban dawaj flipa",
                Latitude = 50.004010f,
                Longitude = 22.031014f
            });
            Spots.Add(new Spot
            {
                Name = "Żółty rail",
                Categories = SpotCategory.Rails,
                Slug = "zolty_rail.jpg",
                ShortDesc = "Nawierzchnia - kostka",
                LongDesc = "Nawierzchnia - kostka",
                Latitude = 50.020511f,
                Longitude = 21.978449f
            });
            Spots.Add(new Spot
            {
                Name = "Barcelona Baranówka",
                Categories = SpotCategory.Others,
                Slug = "barcelona_baranowka.jpg",
                ShortDesc = "Podjazdy, drop z raila",
                LongDesc = "Betonowe podjazdy, drop z raila.",
                Latitude = 50.051953f,
                Longitude = 21.979836f
            });
            Spots.Add(new Spot
            {
                Name = "Pod wiaduktem drop",
                Categories = SpotCategory.Others,
                Slug = "pod_wiaduktem_drop.jpg",
                ShortDesc = "Duży wąski drop",
                LongDesc = "Duży, wąski drop z wiaduktu.",
                Latitude = 50.042891f,
                Longitude = 21.992379f
            });
            Spots.Add(new Spot
            {
                Name = "Łamany murek Targowa",
                Categories = SpotCategory.Ledges,
                Slug = "lamany_murek_targowa.jpg",
                ShortDesc = "Łamany murek",
                LongDesc = "Łamany murek z double setu.",
                Latitude = 50.036836f,
                Longitude = 22.009673f
            });
            Spots.Add(new Spot
            {
                Name = "Pod mostem",
                Categories = SpotCategory.Others,
                Slug = "pod_mostem.jpg",
                ShortDesc = "Curb, flat, plastiki",
                LongDesc = "Metalowy curb, betonowy flat i plastikowe ziomki",
                Latitude = 50.030848f,
                Longitude = 22.004050f
            });
            Spots.Add(new Spot
            {
                Name = "Mini rail delikatesy",
                Categories = SpotCategory.Rails,
                Slug = "mini_rail_delikatesy.jpg",
                ShortDesc = "Mini rail, nawierzchnia - kostka",
                LongDesc = "Mini rail. Trochę krzywy. Flat z koskti",
                Latitude = 50.024473f,
                Longitude = 22.045373f
            });
            Spots.Add(new Spot
            {
                Name = "Filharmonia rail",
                Categories = SpotCategory.Rails,
                Slug = "filharmonia_rail.jpg",
                ShortDesc = "Zjazd na rail",
                LongDesc = "Zjazd na kwadratowy rail. Odjazd z trawy",
                Latitude = 50.033157f,
                Longitude = 22.003826f
            });
            Spots.Add(new Spot
            {
                Name = "Zakręt curb",
                Categories = SpotCategory.Ledges,
                Slug = "zakret_curb.jpg",
                ShortDesc = "Zakręcony curbik",
                LongDesc = "Zakręcony curb, duże przerwy między klocami",
                Latitude = 50.018774f,
                Longitude = 22.005989f
            });
            Spots.Add(new Spot
            {
                Name = "Mini hubba",
                Categories = SpotCategory.Ledges,
                Slug = "mini_hubba.jpg",
                ShortDesc = "Malutka hubba z krótkim najazdem",
                LongDesc = "Malutka hubba z krótkim najazdem",
                Latitude = 50.024253f,
                Longitude = 22.017530f
            });
            Spots.Add(new Spot
            {
                Name = "Gap w zjazd",
                Categories = SpotCategory.Gaps,
                Slug = "gap_w_zjazd.jpg",
                ShortDesc = "Gap nad schodkami w zjazd",
                LongDesc = "Gap nad schodkami w zjazd. Nawierzchnia - kostka",
                Latitude = 50.040631f,
                Longitude = 22.001259f
            });
            Spots.Add(new Spot
            {
                Name = "Biała mini hubba",
                Categories = SpotCategory.Ledges,
                Slug = "biala_mini_hubba.jpg",
                ShortDesc = "Mała hubba z płaskim końcem",
                LongDesc = "Mała hubba z płaskim końcem. Flat - kostka",
                Latitude = 50.040350f,
                Longitude = 22.011407f
            });
            Spots.Add(new Spot
            {
                Name = "Zelwerowicza gap",
                Categories = SpotCategory.Gaps,
                Slug = "zelwerowicza_gap.jpg",
                ShortDesc = "Gap ze ściany",
                LongDesc = "Gap ze ściany. Odjazd na drugą ścianę, albo chodnik.",
                Latitude = 50.000356f,
                Longitude = 22.029967f
            });
            Spots.Add(new Spot
            {
                Name = "Pomnik czynu rewolucyjnego",
                Categories = SpotCategory.Ledges,
                Slug = "pomnik_czynu_rewolucyjnego.jpg",
                ShortDesc = "Murki flat i w dół. Gap na chodnik",
                LongDesc = "Murki flat i w dół. Gap na chodnik",
                Latitude = 50.040591f,
                Longitude = 21.999455f
            });
            Spots.Add(new Spot
            {
                Name = "Murki grz",
                Categories = SpotCategory.Ledges,
                Slug = "murki_grz.jpg",
                ShortDesc = "Murki przy zjeździe",
                LongDesc = "Murki przy zjeździe",
                Latitude = 50.042296f,
                Longitude = 21.999610f
            });
            Spots.Add(new Spot
            {
                Name = "Filharmonia",
                Categories = SpotCategory.Ledges,
                Slug = "filharmonia.jpg",
                ShortDesc = "Dobry flat, dużo murków, schody",
                LongDesc = "Dobry flat, dużo murków i gap ze schodów",
                Latitude = 50.033265f,
                Longitude = 22.004590f
            });
            Spots.Add(new Spot
            {
                Name = "Zielona budka schody",
                Categories = SpotCategory.Gaps,
                Slug = "zielona_budka_schody.jpg",
                ShortDesc = "Schody, flat - kostka",
                LongDesc = "Schody, flat - kostka z dużymi przerwami",
                Latitude = 50.029513f,
                Longitude = 22.019197f
            });
            Spots.Add(new Spot
            {
                Name = "DGK",
                Categories = SpotCategory.Gaps,
                Slug = "dgk.jpg",
                ShortDesc = "Gap nad kostką",
                LongDesc = "Gap nad kostką",
                Latitude = 50.039790f,
                Longitude = 22.006536f
            });
            Spots.Add(new Spot
            {
                Name = "Siedliska pumptrack",
                Categories = SpotCategory.Others,
                Slug = "siedliska_pumptrack.jpg",
                ShortDesc = "Pumptrack z dziurawą nawierzchnią",
                LongDesc = "Pumptrack z wytartą, dziurawą nawierzchnią",
                Latitude = 49.950518f,
                Longitude = 21.935890f
            });
            Spots.Add(new Spot
            {
                Name = "Uniwersytet Rzeszowski",
                Categories = SpotCategory.Ledges,
                Slug = "uniwersytet_rzeszowski.jpg",
                ShortDesc = "Murki, ławki, schodki",
                LongDesc = "Murki, ławki schodki. Flat - odwrócona kostka",
                Latitude = 50.030457f,
                Longitude = 22.013783f
            });
            Spots.Add(new Spot
            {
                Name = "Skatepark",
                Categories = SpotCategory.Others,
                Slug = "skatepark.jpg",
                ShortDesc = "Życie na streecie to nie rurki z kremem",
                LongDesc = "Życie na streecie to nie rurki z kremem",
                Latitude = 50.029311f,
                Longitude = 22.002546f
            });
            Spots.Add(new Spot
            {
                Name = "Frac żółty rail",
                Categories = SpotCategory.Rails,
                Slug = "frac_zolty_rail.jpg",
                ShortDesc = "Mini rail i gap nad nim.",
                LongDesc = "Mini rail i gap nad nim.",
                Latitude = 50.026135f,
                Longitude = 22.017856f
            });
            Spots.Add(new Spot
            {
                Name = "Grind schodki frac",
                Categories = SpotCategory.Ledges,
                Slug = "grind_schodki_frac.jpg",
                ShortDesc = "Schodki do grindowania.",
                LongDesc = "Schodki do grindowania. Nawierzchnia - kostka",
                Latitude = 50.026367f,
                Longitude = 22.018329f
            });
        }

        public static void SetupDatabase()
        {
            if (!File.Exists(App.DatabasaLocation))
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabasaLocation))
                {
                    DummySpotsData dummySpotsData = new DummySpotsData();
                    foreach (Spot spot in dummySpotsData.Spots)
                    {
                        conn.CreateTable<Spot>();
                        conn.Insert(spot);
                    }
                    string connstr = conn.ToString();
                }
            }
        }
        public static List<Spot> Read()
        {
            List<Spot> categorySpots = new List<Spot>();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasaLocation))
            {
                conn.CreateTable<Spot>();
                var spots = conn.Table<Spot>().ToList();
                foreach (Spot spot in spots)
                {
                    categorySpots.Add(spot);
                }
            }
            return categorySpots;
        }

        public static List<Spot> Read(SpotCategory category)
        {
            List<Spot> categorySpots = new List<Spot>();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasaLocation))
            {
                conn.CreateTable<Spot>();
                var spots = conn.Table<Spot>().ToList();
                foreach (Spot spot in spots)
                {
                    if (spot.Categories == category)
                        categorySpots.Add(spot);
                }
            }
            return categorySpots;
        }
    }
}