using System.Windows;

namespace Chess_AdvancedSE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Game game = new();
            Engine engine = new(game);
            MainWindowGrid.Children.Add(new BoardControl(game));
        }
    }
}
