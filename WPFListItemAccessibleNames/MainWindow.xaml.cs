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

            List<Bird> items = new List<Bird>();
            items.Add(new Bird() { Name = "House Sparrow", Habitat = "Cities, suburbs, farms", Voice = "Repeated series of chirrup sounds"});
            items.Add(new Bird() { Name = "Golden-crowned Sparrow", Habitat = "Brushy places, including neighborhoods", Voice = "Series of long, raspy, whistled notes" });
            items.Add(new Bird() { Name = "Song Sparrow", Habitat = "Found throughout Puget Sound Region, up to mountain passes", Voice = "Song begins with several clear notes, followed by lower note, jumbled trill" });
            BirdList.ItemsSource = items;
        }
    }

    public class Bird
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Voice { get; set; }
    }
}
