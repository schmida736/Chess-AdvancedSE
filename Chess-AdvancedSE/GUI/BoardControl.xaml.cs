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
        PlayerTranslator pTrans;
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

            GridColumn.ItemsSource = playerTranslator.GetBoardLayout().layout;

        }

        public virtual void OnSquareClicked(object Sender, MouseButtonEventArgs e)
        {
            var clickPos = Mouse.GetPosition(BoardGrid);
            int row = (int)clickPos.X / 100;
            int col = 7 - ((int)clickPos.Y / 100);
            pTrans.RequestMove(row, col);
        }
    }
}