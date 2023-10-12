using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Wpf.Models
{
    public class Model
    {
        #region Attributes

        /// <summary>
        /// Le nom
        /// </summary>
        private string _Name;

        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou défini le nom
        /// </summary>
        public string Name { get => _Name; set => _Name = value; }

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
