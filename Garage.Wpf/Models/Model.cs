using Garage.Wpf.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Wpf.Models
{
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
