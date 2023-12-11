using System.Collections.ObjectModel;
using Garage.DbLib.Models;
using Prism.Commands;

namespace Garage.Wpf.ViewModels
{
    public class ViewModelBrandView : ViewModelBase
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
        private Model? _SelectedModel;

        #region Commands

        private DelegateCommand<object> _CmdAddBrand;

        #endregion

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

        public Model? SelectedModel
        {
            get => _SelectedModel;
            set => SetProperty(nameof(SelectedModel), ref _SelectedModel, value);
        }
        public DelegateCommand<object> CmdAddBrand 
        { 
            get => _CmdAddBrand; 
            set => _CmdAddBrand = value; 
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur du VM des marques
        /// </summary>
        public ViewModelBrandView()
        {
            CmdAddBrand = new DelegateCommand<object>(AddBrand, CanAddBrand).ObservesProperty(() => this.SelectedBrand);
            
            using (GarageContext context = new GarageContext())
            {
                if (!context.Brands.Any())
                {
                    this.Brands = GenerateData();
                    context.Brands.AddRange(Brands);
                    context.SaveChanges();
                }
                else
                {
                    this.Brands = new ObservableCollection<Brand>(context.Brands);
                }
            }
        }

        #endregion

        #region Commands

        private void AddBrand(object parameter = null)
        {
            Brand brand = new Brand("Nouvelle marque");
            this.Brands.Add(brand);

            using (GarageContext context = new GarageContext())
            {
                context.Brands.Add(brand);
                context.SaveChanges();
            }

        }

        private bool CanAddBrand(object parameter = null) => !(this.SelectedBrand == null);

        private void ReloadContext()
        {
            this.Brands.Clear();
            using (GarageContext context = new GarageContext())
            {
                context.Brands.Add(new Brand("Nouvelle marque"));
                //this._Brands context.Brands.ToList();
                context.SaveChanges();
            }
        }

        #endregion

        #region mockups


        public ObservableCollection<Brand> GenerateData()
        {
            ObservableCollection<Brand> brands = new();
            ObservableCollection<Model> audiModels = new()
            {
                new Model("A4"),
                new Model("A3"),
                new Model("Quattro"),
                new Model("TT"),
                new Model("RS6"),
                new Model("R8"),
            };
            
            this.Brands.Add(new("Audi") { Models = audiModels });
            this.Brands.Add(new("Peugeot"));
            this.Brands.Add(new("Citroën"));
            this.Brands.Add(new("Bugatti"));
            this.Brands.Add(new("Alpine"));
            this.Brands.Add(new("Renault"));

            return brands;
        }
        #endregion

    }
}
