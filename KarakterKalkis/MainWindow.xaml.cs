using System.Windows;
using System.Windows.Controls;

namespace KarakterKalkis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();               
        }

        private void dataGrid_InitializingNewItem(object sender, InitializingNewItemEventArgs e)
        {
            var f = (Fag)e.NewItem;
            f.PropertyChanged += ((FagViewModel)DataContext).UpdateHandler;
            ((FagViewModel)DataContext).UpdateTotal();
        }
    }
}
