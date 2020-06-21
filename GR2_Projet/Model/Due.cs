﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR2_Projet.Model
{
    /// <summary>
    /// Classe représentant le modèle d'échéance mensuelle.
    /// </summary>
    [Serializable()]
    class Due
    {
        /// <summary>
        /// Propriété id.
        /// </summary>
        private string mId;
        public string Id
        {
            get { return mId; }
            set { mId = value; }
        }

        /// <summary>
        /// Propriété nom.
        /// </summary>
        private string mName;
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        /// <summary>
        /// Propriété type d'opération.
        /// </summary>
        private operationType mOperationType;
        public operationType OperationType
        {
            get { return mOperationType; }
            set { mOperationType = value; }
        }

        /// <summary>
        /// Propriété date - Jour de l'échéance dans le mois.
        /// </summary>
        private int mDay;
        public int Day
        {
            get { return mDay; }
            set { mDay = value; }
        }

        /// <summary>
        /// Propriété type de paiement.
        /// </summary>
        private paymentType mPaymentType;
        public paymentType PaymentType
        {
            get { return mPaymentType; }
            set { mPaymentType = value; }
        }

        /// <summary>
        /// Propriété montant.
        /// </summary>
        private int mAmount;
        public int Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public Due()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
