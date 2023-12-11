using Garage.Core.Observable;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.DbLib.Models
{
    /// <summary>
    /// Modèle d'une voiture
    /// </summary>
    [Table("Model")]
    public class Model : ObservableObject
    {
        #region Attributes

        /// <summary>
        /// Identifiant
        /// </summary>
        private int _Identifier;

        /// <summary>
        /// Le nom
        /// </summary>
        private string _Name;

        /// <summary>
        /// Obtient la marque associée
        /// </summary>
        private Brand _Brand;

        /// <summary>
        /// Liste des voitures associées
        /// </summary>
        private ObservableCollection<Car> _Cars;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient l'identifiant
        /// </summary>
        [Key]
        public int Identifier { get => _Identifier; set => _Identifier = value; }

        /// <summary>
        /// Obtient ou défini le nom
        /// </summary>
        public string Name { get => _Name; set => SetProperty(nameof(Name), ref _Name, value);}

        /// <summary>
        /// Obtient ou défini la marque
        /// </summary>
        public Brand Brand { get => _Brand; set => _Brand = value; }

        /// <summary>
        /// Obtient ou défini la liste des voitures associées
        /// </summary>
        public ObservableCollection<Car> Cars { get => _Cars; set => _Cars = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instancie le modèle
        /// </summary>
        /// <param name="name">Nom du modèle</param>
        public Model(string name)
        {
            this.Name = name;
        }
        #endregion
    }
}
