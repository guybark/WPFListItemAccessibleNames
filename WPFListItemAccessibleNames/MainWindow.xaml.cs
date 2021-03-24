using System.Collections.Generic;
using System.Windows;

namespace WPFListItemAccessibleNames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Animal> dogs = new List<Animal>();
            dogs.Add(new Animal() { Name = "Spaniel", Habitat = "Lounge and garden", Voice = "Woof" });
            dogs.Add(new Animal() { Name = "Labrador", Habitat = "Kitchen", Voice = "Woof" });
            DogList.ItemsSource = dogs;

            List<Animal> birds = new List<Animal>();
            birds.Add(new Animal() { Name = "House Sparrow", Habitat = "Cities, suburbs, farms", Voice = "Repeated series of chirrup sounds"});
            birds.Add(new Animal() { Name = "Golden-crowned Sparrow", Habitat = "Brushy places, including neighborhoods", Voice = "Series of long, raspy, whistled notes" });
            birds.Add(new Animal() { Name = "Song Sparrow", Habitat = "Found throughout Puget Sound Region, up to mountain passes", Voice = "Song begins with several clear notes, followed by lower note, jumbled trill" });
            BirdList.ItemsSource = birds;
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Voice { get; set; }
    }
}
