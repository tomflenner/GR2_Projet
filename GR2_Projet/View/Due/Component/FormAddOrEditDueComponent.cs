﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View.Due.Component
{
    public partial class FormAddOrEditDueComponent : UserControl
    {
        public FormAddOrEditDueComponent()
        {
            InitializeComponent();
        }

        public FormAddOrEditDueComponent(Model.Due due)
        {
            InitializeComponent();
        }
    }
}
