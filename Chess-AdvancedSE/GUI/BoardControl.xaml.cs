using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chess_AdvancedSE
{
    /// <summary>
    /// Interaction logic for BoardControl.xaml
    /// </summary>
    public partial class BoardControl : UserControl
    {

        public BoardControl(Game game)
        {
            InitializeComponent();

            //Set board background
            ScaleTransform flipBoard = new();
            flipBoard.ScaleX = -1;
            flipBoard.CenterX = 0.5;

            ImageBrush brush = new();
            brush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/board.png"));
            //flip board for black player
            if (!game.player.Color)
            {
                brush.RelativeTransform = flipBoard;
            }
            Background = brush;

            //game.board.LayoutChanged += UpdateBoard;

            GridColumn.ItemsSource = game.board.layout;

        }

        //private static void UpdateBoard(object Sender, Board board)
        //{
        //    //Iterate through board square array and set piece backgrounds appropriately
        //}
        private void OnClick(object Sender, RoutedEventArgs e)
        {
            //Define square click
            MessageBox.Show("CLICKED");
        }
    }
}