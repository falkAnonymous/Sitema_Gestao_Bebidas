﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quick_Drinks.Janelas.PastProduto.CadastroProduto;
using System.Windows.Forms;

namespace Quick_Drinks
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
