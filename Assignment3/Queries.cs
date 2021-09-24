using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;


namespace BDSA2021.Assignment03
{
    public class Queries
    {
        public static IEnumerable<String> WizardsInventedByRowlingLINQ(IReadOnlyCollection<Wizard> wizards)
        {
            return from w in wizards
                   where w.Creator.Contains("Rowling")
                   select w.Name;
        }

        public static IEnumerable<String> WizardsInventedByRowlingExtensionMethods(IReadOnlyCollection<Wizard> wizards)
        {
            return wizards.Where(w => w.Creator.Contains("Rowling"))
                          .Select(w => w.Name);
        }

        public static int? YearWhenSithLordsWereIntroducedLINQ(IReadOnlyCollection<Wizard> wizards)
        {
            return (from w in wizards
                   where w.Name.Contains("Darth")
                   orderby w.Year
                   select w.Year).First();
        }

        public static int? YearWhenSithLordsWereIntroducedExtensionMethods(IReadOnlyCollection<Wizard> wizards)
        {
            return wizards.Where(w => w.Name.Contains("Darth"))
                          .OrderBy(w => w.Year)
                          .Select(w => w.Year)
                          .First();
        }

        public static IEnumerable<(string, int?)> UniqueHarryPotterWizardsLINQ(IReadOnlyCollection<Wizard> wizards)
        {
            return (from w in wizards
                   where w.Medium.Contains("Harry Potter")
                      && w.Creator.Contains("Rowling")
                   select (w.Name, w.Year)).Distinct();
        }

        public static IEnumerable<(string, int?)> UniqueHarryPotterWizardsExtensionMethods(IReadOnlyCollection<Wizard> wizards)
        {
            return wizards.Where(w => w.Medium.Contains("Harry Potter") 
                                      && w.Creator.Contains("Rowling"))
                          .Select(w => (w.Name, w.Year))
                          .Distinct();
        }

        public static IEnumerable<Wizard> StrangeSortLINQ(IReadOnlyCollection<Wizard> wizards)
        {
            return from w in wizards
                   orderby w.Creator descending, w.Name ascending
                   select w;
        }

        public static IEnumerable<Wizard> StrangeSortExtensionMethods(IReadOnlyCollection<Wizard> wizards)
        {
            return wizards.OrderByDescending(w => w.Creator)
                          .ThenBy(w => w.Name);
        }
    }
}
