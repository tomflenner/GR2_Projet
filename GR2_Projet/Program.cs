﻿using GR2_Projet.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewManager.Instance.ShowMainForm();

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "data.dat"))
            {
                AppFixtures.CreateFakeUser();
                AppFixtures.CreateFakeAccount();
                AppFixtures.Save();
            }
            else { }

            AppFixtures.Read();
            Application.Run();
       }
    }
}
