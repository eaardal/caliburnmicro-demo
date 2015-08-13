using System.Collections.ObjectModel;
using Caliburn.Micro;

namespace CaliburnDemo
{
    class PeopleViewModel : Screen
    {
        public ObservableCollection<string> Names { get; set; }
        public ObservableCollection<Person> People { get; set; }

        protected override void OnActivate()
        {
            Names = new ObservableCollection<string> {"Bob", "Anne", "Harry"};
            People = new ObservableCollection<Person>
            {
                new Person
                {
                    Name = "Jack",
                    Email = "jack@jack.com"
                },
                new Person
                {
                    Name = "John",
                    Email = "john@john.com"
                },
                new Person
                {
                    Name = "Sarah",
                    Email = "sarah@sarah.com"
                }
            };
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
