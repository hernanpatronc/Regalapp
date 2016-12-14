using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace RegalApp
{
    public class Item
    {
        public string Text { get; set; }
        public string Image { get; set; }
    }
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            ObservableCollection<Item> listMaster = new ObservableCollection<Item>();
            listMaster.Add(new Item {
                Text = "Inicio",
                Image = "home.png",
            });
            listMaster.Add(new Item
            {
                Text = "Configuración",
                Image = "configuration.png",
            });
            ListViewUser.ItemsSource = listMaster;
        }
    }
}
