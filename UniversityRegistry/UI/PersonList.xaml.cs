using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using UniversityRegistry.Data;

namespace UniversityRegistry.UI
{
    /// <summary>
    /// Interaction logic for RegistryList.xaml
    /// </summary>
    public partial class PersonList : UserControl
    {
        /// <summary>
        /// Proxy event handler
        /// </summary>
        public event SelectionChangedEventHandler SelectionChanged;


        /// <summary>
        /// Initializing
        /// </summary>
        public PersonList()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Proxy event listener that passes on SelectionChanged events
        /// </summary>
        /// <param name="sender">ListViewthat has selection changed</param>
        /// <param name="e">Event args</param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }


        private void AddNewPersonButtonClick(object sender, RoutedEventArgs e)
        {
            var person = new Person();
            person.FirstName = "FirstName";
            person.LastName = "LastName";
            person.Role = Role.Staff;
            person.DateOfBirth = DateTime.Now;
            person.Active = true;

            if (DataContext is ObservableCollection<Person> people)
            {
                people.Add(person);
            }
        }

    }
}
