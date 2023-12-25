using CreatePDFOnWeb.Models;

namespace CreatePDFOnWeb.PDFHelper
{
    public class Data
    {
        public static List<Member> GetAllMembers() =>
            new()
            {
            new Member { Firstname = "Bernfried", LastName = "Schuster", Street = "Karl-Jürgen-Gasse 7", PLZ = 78391, City = "Jena" },
            new Member { Firstname = "Tobias", LastName = "Kraushaar", Street = "Knappering 087", PLZ = 80284, City = "Herford" },
            new Member { Firstname = "Vincenzo", LastName = "Lorch", Street = "Binnerweg 0/5", PLZ = 66005, City = "Biedenkopf" },
            new Member { Firstname = "Rico", LastName = "Hesse", Street = "Kästerweg 590", PLZ = 07167, City = "Neu-Ulm" },
            new Member { Firstname = "Hans-Heinrich", LastName = "Killer", Street = "Hornichweg 28", PLZ = 76221, City = "Lemgo" },
            new Member { Firstname = "Vinko", LastName = "Börner", Street = "Reisingallee 5", PLZ = 36873, City = "Ebersberg" },
            new Member { Firstname = "Marlies", LastName = "Kallert", Street = "Klaas-Tintzmann-Weg 876", PLZ = 24237, City = "Cloppenburg" },
            new Member { Firstname = "Edith", LastName = "Baum", Street = "Friedbert-Holt-Gasse 457", PLZ = 15503, City = "Haldensleben" },
            new Member { Firstname = "Annekatrin", LastName = "Misicher", Street = "Rosalia-Dörr-Gasse 229", PLZ = 88404, City = "Pößneck" },
            new Member { Firstname = "Mathilde", LastName = "Trub", Street = "Henschelallee 424", PLZ = 38122, City = "Calau" },
            new Member { Firstname = "Stavros", LastName = "Drewes", Street = "Harro-Junken-Platz 1/6", PLZ = 52950, City = "Neustadtner Waldnaab" },
            new Member { Firstname = "Gerfried", LastName = "Klemm", Street = "Paffrathallee 79", PLZ = 25891, City = "Böblingen" },
            new Member { Firstname = "Zoltan", LastName = "Preiß", Street = "Thekla-Rogner-Platz 810", PLZ = 68042, City = "Aurich" },
            new Member { Firstname = "Reiner", LastName = "Mitschke", Street = "Zirmeweg 58", PLZ = 63374, City = "Grevenbroich" },
            new Member { Firstname = "Bogdan", LastName = "Förster", Street = "Alan-Binner-Platz 4/1", PLZ = 81198, City = "Meißen" },
            new Member { Firstname = "Axel", LastName = "Gehringer", Street = "Heckerweg 4", PLZ = 21124, City = "Geldern" },
            new Member { Firstname = "Jost", LastName = "Köster", Street = "Sauerring 566", PLZ = 41000, City = "Rathenow" },
            new Member { Firstname = "Jeannette", LastName = "Hartung", Street = "Jäntschstraße 30", PLZ = 26618, City = "Regen" },
            new Member { Firstname = "Aurelia", LastName = "Ladeck", Street = "Philippe-Mosemann-Gasse 521", PLZ = 45259, City = "Gütersloh" },
            new Member { Firstname = "Hakan", LastName = "Döhn", Street = "Eberhardtplatz 4", PLZ = 33840, City = "Herzberg" }
            };
    }
}
