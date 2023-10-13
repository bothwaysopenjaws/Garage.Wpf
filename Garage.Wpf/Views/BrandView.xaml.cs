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
using Garage.Wpf.ViewModels;

namespace Garage.Wpf.Views
{
    /// <summary>
    /// Logique d'interaction pour BrandView.xaml
    /// </summary>
    public partial class BrandView : UserControl
    {

        #region Constructors
/// <summary>
        /// Instancie le contrôle utilisateur de la vue
        /// </summary>
        public BrandView()
        {
            InitializeComponent();
            this.DataContext = new ViewModelBrandView();
        }

        #endregion

        #region Methods

        #region Marques
        /// <summary>
        /// Manage la modification de sélection de marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _BrandListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (((ViewModelBrandView)this.DataContext).SelectedBrand == null)
            {
                _BrandNameTextBox.Text = "";
            }
            else
            {
                _BrandNameTextBox.Text = ((ViewModelBrandView)this.DataContext).SelectedBrand.Name;
            }

        }

        /// <summary>
        /// Met à jour une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBrandButton_Click(object sender, RoutedEventArgs e)
        {
            if (((ViewModelBrandView)this.DataContext).SelectedBrand != null)
            {
                ((ViewModelBrandView)this.DataContext).SelectedBrand.Name = _BrandNameTextBox.Text;

            }
        }

        /// <summary>
        /// Supprime une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBrandButton_Click(object sender, RoutedEventArgs e)
        {
            if (((ViewModelBrandView)this.DataContext).SelectedBrand != null)
            {
                ((ViewModelBrandView)this.DataContext).Brands?.Remove(((ViewModelBrandView)this.DataContext).SelectedBrand);
            }
        }

        /// <summary>
        /// Permet l'ajout d'une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _AddBrandButton_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelBrandView)this.DataContext).Brands.Add(new Brand("Nouvelle marque"));
        }

        #endregion

        #region Modèles

        /// <summary>
        /// Manage la modification de sélection d'un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ModelListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (((ViewModelBrandView)this.DataContext).SelectedModel == null)
            {
                _ModelNameTextBox.Text = "";
            }
            else
            {
                _ModelNameTextBox.Text = ((ViewModelBrandView)this.DataContext).SelectedModel.Name;
            }

        }

        /// <summary>
        /// Met à jour un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateModelButton_Click(object sender, RoutedEventArgs e)
        {
            if (((ViewModelBrandView)this.DataContext).SelectedModel != null)
            {
                ((ViewModelBrandView)this.DataContext).SelectedModel.Name = _ModelNameTextBox.Text;

            }
        }

        /// <summary>
        /// Supprime un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteModelButton_Click(object sender, RoutedEventArgs e)
        {
            if (((ViewModelBrandView)this.DataContext).SelectedModel != null)
            {
                ((ViewModelBrandView)this.DataContext).SelectedBrand.Models?.Remove(((ViewModelBrandView)this.DataContext).SelectedModel);
            }
        }

        /// <summary>
        /// Permet l'ajout d'un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _AddModelButton_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelBrandView)this.DataContext).SelectedBrand.Models.Add(new Model("Nouvelle marque"));
        }

        #endregion

        #endregion




    }
}
