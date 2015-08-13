using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Caliburn.Micro;

namespace CaliburnDemo
{
    internal class CountryListingViewModel : Screen
    {
        public ObservableCollection<Country> Countries { get; set; }

        protected override void OnActivate()
        {
            Countries = new ObservableCollection<Country>(ObjectGraph.Generate());
        }
    }
}