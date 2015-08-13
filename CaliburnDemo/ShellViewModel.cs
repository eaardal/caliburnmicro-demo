using System.Windows;
using Caliburn.Micro;

namespace CaliburnDemo
{
    sealed class ShellViewModel : Conductor<Screen>.Collection.AllActive
    {
        private string _name;
        private Screen _countryListing;
        private Screen _people;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello => !string.IsNullOrEmpty(Name);

        public void SayHello()
        {
            MessageBox.Show(Name);
        }

        public Screen CountryListing
        {
            get { return _countryListing; }
            set
            {
                if (Equals(value, _countryListing)) return;
                _countryListing = value;
                NotifyOfPropertyChange(() => CountryListing);
            }
        }

        public Screen People
        {
            get { return _people; }
            set
            {
                if (Equals(value, _people)) return;
                _people = value;
                NotifyOfPropertyChange(() => People);
            }
        }

        public ShellViewModel()
        {
            CountryListing = new CountryListingViewModel();
            People = new PeopleViewModel();

            ActivateItem(CountryListing);
            ActivateItem(People);
        }
    }
}