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

        #region Properties

        /// <summary>
        /// Liste des marques
        /// </summary>
        public List<Brand> Brands { get; set; }

        /// <summary>
        /// La marque sélectionnée
        /// </summary>
        public Brand? SelectedBrand { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Instancie le contrôle utilisateur de la vue
        /// </summary>
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
            this.DataContext = this;

        }

        #endregion

        #region Methods

        /// <summary>
        /// Manage la modification de sélection de marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _BrandListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedBrand == null)
            {
                _BrandGroupBox.Visibility = Visibility.Collapsed;
                _BrandNameTextBox.Text = "";
            }
            else
            {
                _BrandGroupBox.Visibility = Visibility.Visible;
                _BrandNameTextBox.Text = SelectedBrand.Name;
            }

        }

        /// <summary>
        /// Met à jour une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBrandButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBrand != null)
            {
                SelectedBrand.Name = _BrandNameTextBox.Text;

            }
        }

        /// <summary>
        /// Supprime une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBrandButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBrand != null)
            {
                this.Brands?.Remove(SelectedBrand);
            }
        }

        /// <summary>
        /// Permet l'ajout d'une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _AddBrandButton_Click(object sender, RoutedEventArgs e)
        {
            this.Brands.Add(new Brand("Nouvelle marque"));
        }

        #endregion


    }
}
