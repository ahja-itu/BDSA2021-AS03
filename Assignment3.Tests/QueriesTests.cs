using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void WizardsInventedByRowlingLINQ_given_two_wizards_from_rowling_amonst_four_should_return_two_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            var rowlingWizards = Queries.WizardsInventedByRowlingLINQ(wizards);
            
            Assert.Equal(3, rowlingWizards.Count());
        }

        [Fact]
        public void WizardsInventedByRowlingExtensionMethods_given_all_wizards_return_result_two()
        {
            var wizards = Wizard.Wizards.Value;

            var rowlingWizards = Queries.WizardsInventedByRowlingExtensionMethods(wizards);

            Assert.Equal(3, rowlingWizards.Count());
        }

        [Fact]
        public void YearWhenSithLordsWereIntroducedLINQ_given_all_wizards_return_year_1977()
        {
            var wizards = Wizard.Wizards.Value;

            int? year = Queries.YearWhenSithLordsWereIntroducedLINQ(wizards);

            Assert.Equal(1977, year);
        }

        [Fact]
        public void YearWhenSithLordsWereIntroducedExtensionMethods_given_all_wizards_return_year_1977()
        {
            var wizards = Wizard.Wizards.Value;

            int? year = Queries.YearWhenSithLordsWereIntroducedExtensionMethods(wizards);

            Assert.Equal(1977, year);
        }

        [Fact]
        public void UniqueHarryPotterWizardsLINQ_given_csv_return_harry_potter_and_voldemort()
        {
            var wizards = Wizard.Wizards.Value;

            var uniqueHSWizards = Queries.UniqueHarryPotterWizardsLINQ(wizards);

            Assert.Equal(2, uniqueHSWizards.Count());
        }

        [Fact]
        public void UniqueHarryPotterWizardsExtensionMethods_given_csv_return_harry_potter_and_voldemort()
        {
            var wizards = Wizard.Wizards.Value;

            var uniqueHSWizards = Queries.UniqueHarryPotterWizardsExtensionMethods(wizards);

            Assert.Equal(2, uniqueHSWizards.Count());
        }

        [Fact]
        public void StrangeSortLINQ_given_csv_return_wizards_in_reverse_by_creator_and_then_wizard()
        {
            var wizards = Wizard.Wizards.Value;

            var strangeList = Queries.StrangeSortLINQ(wizards);

            Assert.Equal("J.R.R. Tolkien", strangeList.First().Creator);
            Assert.Equal("Author #0", strangeList.Last().Creator);
        }

        [Fact]
        public void StrangeSortExtensionMethods_given_csv_return_wizards_in_reverse_by_creator_and_then_wizard()
        {
            var wizards = Wizard.Wizards.Value;

            IEnumerable<Wizard> strangeList = Queries.StrangeSortExtensionMethods(wizards);

            Assert.Equal("J.R.R. Tolkien", strangeList.First().Creator);
            Assert.Equal("Author #0", strangeList.Last().Creator);
        }
    }
}
