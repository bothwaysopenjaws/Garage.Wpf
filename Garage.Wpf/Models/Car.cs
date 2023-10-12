﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Wpf.Models
{
    public class Car
    {
        #region Attributes

        /// <summary>
        /// Modèle
        /// </summary>
        private Model _Model;

        /// <summary>
        /// Année
        /// </summary>
        private int? _Year;

        /// <summary>
        /// Kilomètres
        /// </summary>
        private int? _Kilometers;

        private string _Registration;

        #endregion

        #region Properties
      /// <summary>
        /// Obtient ou défini le modèle
        /// </summary>
        public Model Model { get => _Model; set => _Model = value; }

        /// <summary>
        /// Obtient ou défini l'année
        /// </summary>
        public int? Year { get => _Year; set => _Year = value; }
     /// <summary>
        /// Obtient ou défini le nombre de kilomètre
        /// </summary>
        public int? Kilometers { get => _Kilometers; set => _Kilometers = value; }

        /// <summary>
        /// Immatriculation
        /// </summary>
        public string Registration { get => _Registration; set => _Registration = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instancie une voiture
        /// </summary>
        /// <param name="model"></param>
        /// <param name="immatriculation"></param>
        public Car(Model model, string immatriculation) 
        {
            this.Model = model;
            this.Registration= immatriculation;
        }


        #endregion
    }
}
