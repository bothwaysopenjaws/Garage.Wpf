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
using Garage.Wpf.Models;

namespace Garage.Wpf.Views
{
    /// <summary>
    /// Logique d'interaction pour BrandView.xaml
    /// </summary>
    public partial class BrandView : UserControl
    {
        public List<Brand> Brands { get; set; }

        public BrandView()
        {
            InitializeComponent();
            this.Brands = new List<Brand>();

            this.Brands.Add(new Brand("Audi"));
            this.Brands.Add(new Brand("Peugeot"));
            this.Brands.Add(new Brand("Citroën"));
            this.Brands.Add(new Brand("Bugatti"));
            this.Brands.Add(new Brand("Alpine"));
            this.Brands.Add(new Brand("Renault"));

        }
    }
}
