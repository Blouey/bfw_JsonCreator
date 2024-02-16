using System.Text.Json;
using System.Windows;


namespace WPF_JsonCreator_2024_02_06;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Window_Loaded(object sender, RoutedEventArgs e)
    {
        DatePckr.SelectedDate = new DateTime(1900, 1, 1);
        
    }

    public List<Person> LPerson = new List<Person>();
    public void BtnCreateJson_Click(object sender, RoutedEventArgs e)
    {
        Person person = new Person();
        person.Name = NameTxt.Text;
        person.Vorname = VornameTxt.Text;
        person.Geburtsdatum = DatePckr.SelectedDate.Value;
        LPerson.Add(person);
        string json = JsonSerializer.Serialize(LPerson, new JsonSerializerOptions { WriteIndented = true });
        JsonTxt.Text = json;
    }
}