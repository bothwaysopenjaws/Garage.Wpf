using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Wpf.Models
{
    /// <summary>
    /// Marque
    /// </summary>
    public class Brand
    {
        #region Attributes

        /// <summary>
        /// Le nom
        /// </summary>
        private string _Name;
        /// <summary>
        /// Liste des modèles de la marque
        /// </summary>
        private List<Model> _Models;

        #endregion

        #region Properties
      /// <summary>
        /// Obtient ou défini le nom
        /// </summary>
        public string Name { get => _Name; set => _Name = value; }
        /// <summary>
        /// Obtient ou défini la liste des modèles
        /// </summary>
        public List<Model> Models { get => _Models; set => _Models = value; }

        #endregion

        #region Constructors
        /// <summary>
        /// Instancie une marque
        /// </summary>
        /// <param name="name">Nom d'une marque</param>
        public Brand(string name)
        {
            this.Name = name;
            this.Models = new List<Model>();
        }

        #endregion
    }
}
