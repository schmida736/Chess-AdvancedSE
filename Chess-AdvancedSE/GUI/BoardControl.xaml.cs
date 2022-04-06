using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Chess_AdvancedSE
{
    /// <summary>
    /// Interaction logic for BoardControl.xaml
    /// </summary>
    public partial class BoardControl : UserControl
    {
        PlayerTranslator pTrans;
        Game _game;
        Tuple<int, int> coords_from = null;
        Tuple<int, int> coords_to = null;
        public BoardControl(Game game)
        {
            InitializeComponent();

            pTrans = new PlayerTranslator(game);
            this._game = game;

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

            GridColumn.ItemsSource = game.board.viewModel.layout;

        }

        public virtual void OnSquareClicked(object Sender, MouseButtonEventArgs e)
        {
            var clickPos = Mouse.GetPosition(BoardGrid);
            Console.WriteLine(clickPos.X + " " + clickPos.Y);
            int col = (int)clickPos.X / 100;
            int row = ((int)clickPos.Y / 100);

            if(coords_from == null){
                coords_from = Tuple.Create(row, col);
            }
            else{
                coords_to = Tuple.Create(row, col);
                pTrans.RequestMove(coords_from, coords_to);
                coords_from = coords_to = null;
            }
            GridColumn.Items.Refresh();
        }
    }
}