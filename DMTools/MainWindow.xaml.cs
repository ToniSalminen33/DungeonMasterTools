using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DMTools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public NPCViewModel nPCViewModel = new NPCViewModel();
        ObservableCollection<NPCModel> npcModels = new ObservableCollection<NPCModel>();
        public static MainWindow instance;
        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            TavernPatronList.ItemsSource = npcModels;
            TavernPatronList.DataContext = npcModels;
        }

        private void TavernResidentButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            npcModels.Clear();
            nPCViewModel.GenerateNPC(npcModels, Convert.ToInt32(XPatronValueBox.Text), button.Name);
            TavernPatronList.Items.Refresh();
        }
    }
}
