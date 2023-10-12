using Garage.Wpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Wpf.ViewModels
{
    class ViewModelBrandView : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Liste des marques
        /// </summary>
        private ObservableCollection<Brand> _Brands;

        /// <summary>
        /// La marque sélectionnée
        /// </summary>
        private Brand? _SelectedBrand;

        /// <summary>
        /// Le modèle sélectionné
        /// </summary>
        private Brand? _SelectedModel;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini la liste des marques
        /// </summary>
        public ObservableCollection<Brand> Brands 
        { 
            get => _Brands; 
            set => SetProperty(nameof(Brands), ref _Brands, value); 
        }
 /// <summary>
        /// Obtient ou défini la marque séléctionné
        /// </summary>
        public Brand? SelectedBrand 
        { 
            get => _SelectedBrand; 
            set => SetProperty(nameof(SelectedBrand), ref _SelectedBrand, value); 
        }

        public Brand? SelectedModel
        {
            get => _SelectedBrand;
            set => SetProperty(nameof(SelectedModel), ref _SelectedModel, value);
        }
        #endregion

        #region Constructors

        public ViewModelBrandView()
        {
            ObservableCollection<Model> audiModels = new ObservableCollection<Model>()
            {
                new Model("A4"),
                new Model("A3"),
                new Model("Quattro"),
                new Model("TT"),
                new Model("RS6"),
                new Model("R8"),
            };

            this.Brands = new ObservableCollection<Brand>();
            this.Brands.Add(new Brand("Audi") { Models= audiModels });
            this.Brands.Add(new Brand("Peugeot"));
            this.Brands.Add(new Brand("Citroën"));
            this.Brands.Add(new Brand("Bugatti"));
            this.Brands.Add(new Brand("Alpine"));
            this.Brands.Add(new Brand("Renault"));
        }

        #endregion

    }
}
