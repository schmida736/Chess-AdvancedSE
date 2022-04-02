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
        Tuple<int, int> coords_from = null;
        Tuple<int, int> coords_to = null;
        public BoardControl(PlayerTranslator playerTranslator)
        {
            InitializeComponent();

            this.pTrans = playerTranslator;

            //Set board background
            ScaleTransform flipBoard = new();
            flipBoard.ScaleX = -1;
            flipBoard.CenterX = 0.5;

            ImageBrush brush = new();
            brush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/board.png"));
            //flip board for black player
            if (!playerTranslator.getPlayerColor())
            {
                brush.RelativeTransform = flipBoard;
            }
            Background = brush;

            //game.board.LayoutChanged += UpdateBoard;

            GridColumn.ItemsSource = playerTranslator.GetBoardLayout().GetAsList();

        }

        public virtual void OnSquareClicked(object Sender, MouseButtonEventArgs e)
        {
            var clickPos = Mouse.GetPosition(BoardGrid);
            int row = (int)clickPos.X / 100;
            int col = 7 - ((int)clickPos.Y / 100);

            if(coords_from == null){
                coords_to = Tuple.Create(row, col);
            }
            else{
                coords_to = Tuple.Create(row, col);
                pTrans.RequestMove(coords_to, coords_from);
                coords_from = coords_to = null;
            }
        }
    }
}