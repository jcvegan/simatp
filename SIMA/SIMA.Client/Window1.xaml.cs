using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using SIMA.Client.Gestion;

namespace SIMA.Client
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void rbtnChecked(object sender, RoutedEventArgs e)
        {
            RadTileViewItem item = new RadTileViewItem();
            StyleManager.SetTheme(item, new SummerTheme());
            item.Header = (sender as RadRibbonToggleButton).Content;
            switch (item.Header.ToString())
            {
                case "Perfiles":
                    item.Content = new frmGestionarPerfiles();
                    break;
                case "Tablas":
                    item.Content = new frmGestionarTablas();
                    break;
                case "Estados":
                    item.Content = new frmGestionarEstados();
                    break;
            }
            
            TileContainerRoot.Items.Add(item);
        }

        private void rbtnUnchecked(object sender, RoutedEventArgs e)
        {
            foreach (RadTileViewItem item in TileContainerRoot.Items)
            {
                if (item.Header == (sender as RadRibbonToggleButton).Content)
                {
                    TileContainerRoot.Items.Remove(item);
                    break;
                }
            }
        }

        
    }
}
