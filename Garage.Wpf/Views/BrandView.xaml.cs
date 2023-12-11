using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Garage.Wpf.ViewModels;
using Garage.Core;
using Garage.DbLib.Models;

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
        private void BrandListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => _BrandNameTextBox.Text = (DataContext as ViewModelBrandView)?.SelectedBrand?.Name ?? "";

        /// <summary>
        /// Met à jour une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBrandButton_Click(object sender, RoutedEventArgs e)
        {
            Brand? brand = (DataContext as ViewModelBrandView)?.SelectedBrand;
            if (brand is not null)
                brand.Name = _BrandNameTextBox.Text;
        }

        /// <summary>
        /// Supprime une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBrandButton_Click(object sender, RoutedEventArgs e)
        {
                ((ViewModelBrandView)this.DataContext).RemoveBrand();
        }
        /*
        /// <summary>
        /// Permet l'ajout d'une marque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBrandButton_Click(object sender, RoutedEventArgs e) => ((ViewModelBrandView)this.DataContext).Brands.Add(new Brand("Nouvelle marque"));*/

        #endregion

        #region Modèles

        /// <summary>
        /// Manage la modification de sélection d'un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModelListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => _ModelNameTextBox.Text = (DataContext as ViewModelBrandView)?.SelectedModel?.Name ??
             "";

        /// <summary>
        /// Met à jour un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateModelButton_Click(object sender, RoutedEventArgs e)
        {
            Model? model = (this.DataContext as ViewModelBrandView)?.SelectedModel;
            if (model != null)
            {
                model.Name = _ModelNameTextBox.Text;

            }
        }

        /// <summary>
        /// Supprime un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteModelButton_Click(object sender, RoutedEventArgs e)
        {
            Model? model = (DataContext as ViewModelBrandView)?.SelectedModel;
            if (model is not null)
            {
                _ = ((DataContext as ViewModelBrandView)?.SelectedBrand?.Models?.Remove(model));
            }
        }

        /// <summary>
        /// Permet l'ajout d'un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddModelButton_Click(object sender, RoutedEventArgs e) => (DataContext as ViewModelBrandView)?.SelectedBrand?.Models.Add(new Model("Nouvelle marque"));

        #endregion

        #endregion




    }
}
