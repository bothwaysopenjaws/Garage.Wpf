﻿using Garage.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Garage.Wpf.Models
{
    /// <summary>
    /// Marque
    [Table("Brand")]
    public class Brand : ObservableObject
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
        /// Liste des modèles de la marque
        /// </summary>
        private ObservableCollection<Model> _Models;

        #endregion

        #region Properties

        [Key]
        public int Identifier { get => _Identifier; set => _Identifier = value; }

        /// <summary>
        /// Obtient ou défini le nom
        /// </summary>
        public string Name 
        { 
            get => _Name;
            set => SetProperty(nameof(Name), ref _Name, value); 
        }
        
        /// <summary>
        /// Obtient ou défini la liste des modèles
        /// </summary>
        public ObservableCollection<Model> Models 
        { get => _Models;
            set => SetProperty(nameof(Models), ref _Models, value); 
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Instancie une marque
        /// </summary>
        /// <param name="name">Nom d'une marque</param>
        public Brand(string name)
        {
            this.Name = name;
            this.Models = new ObservableCollection<Model>();
        }

        #endregion
    }
}
