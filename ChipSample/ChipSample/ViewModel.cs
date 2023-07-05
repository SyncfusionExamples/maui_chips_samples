using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ChipSample;

public class ViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Person> employees;
    public ObservableCollection<Person> Employees
    {
        get { return employees; }
        set { Employees = value; OnPropertyChanged("Employees"); }
    }

    public ViewModel()
    {
        employees = new ObservableCollection<Person>();
        employees.Add(new Person() { Name = "John" });
        employees.Add(new Person() { Name = "James" });
        employees.Add(new Person() { Name = "Linda" });
        employees.Add(new Person() { Name = "Rose" });
        employees.Add(new Person() { Name = "Mark" });
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string property)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}