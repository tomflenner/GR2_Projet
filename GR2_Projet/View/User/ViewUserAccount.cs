﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View
{
    /// <summary>
    /// Classe ViewUserAccount. Elle permet de représenter la vue lié au modèle des comptes bancaires.
    /// </summary>
    public partial class ViewUserAccount : BaseView
    {
        private static bool isShowComponentActive;
        private static bool isAddComponentActive;
        #region Components
        /// <summary>
        /// Composant permettant d'ajouter un compte bancaire.
        /// </summary>
        private Account.Component.AddAccountComponent addComponent;
        /// <summary>
        /// Composant permettant d'afficher les comptes bancaires.
        /// </summary>
        private Account.Component.ShowAccountComponent showComponent;
        #endregion Components

        /// <summary>
        /// Constructeur.
        /// </summary>
        public ViewUserAccount()
        {
            InitializeComponent();

            this.userNameLbl.Text = Program.currentLoggedUser.Username;

            ShowButtons(false);
            EnableButtons(false);

            showAccountLogic();
        }

        public void ShowButtons(bool isVisible)
        {
            this.delBtn.Visible = isVisible;
            this.editBtn.Visible = isVisible;
        }

        public void EnableButtons(bool isEnabled)
        {
            this.delBtn.Enabled = isEnabled;
            this.editBtn.Enabled = isEnabled;
        }

        /// <summary>
        /// Logique d'affichage du composant permettant d'afficher les comptes bancaires.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAccount_Click(object sender, EventArgs e)
        {
            if (!isShowComponentActive)
            {
                showAccountLogic();
                this.adminComponentPanel.Text = "Mes comptes";
                ShowButtons(true);
            }
        }

        private void showAccountLogic()
        {
            ClearComponentRessources(adminComponentPanel);
            showComponent = new Account.Component.ShowAccountComponent(Program.currentLoggedUser.Accounts);
            ChangeComponent(adminComponentPanel, showComponent);

            isShowComponentActive = true;
            isAddComponentActive = false;
        }

        /// <summary>
        /// Logique d'affichage du composant permettant d'ajouter un comptes bancaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addAccount_Click(object sender, EventArgs e)
        {
            if (!isAddComponentActive)
            {
                addAccountLogic();
                this.adminComponentPanel.Text = "Ajouter un compte";
                ShowButtons(false);
            }
        }

        private void addAccountLogic()
        {
            ClearComponentRessources(adminComponentPanel);
            addComponent = new Account.Component.AddAccountComponent();
            ChangeComponent(adminComponentPanel, addComponent);

            isAddComponentActive = true;
            isShowComponentActive = false;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(showComponent.getCurrentAccount().Name);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            Controller.AccountController.DeleteAccount(Program.currentLoggedUser, showComponent.getCurrentAccount().Id);
            showComponent.UpdateData(Program.currentLoggedUser.Accounts);
        }
    }
}