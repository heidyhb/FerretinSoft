﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pe.edu.pucp.ferretinsoft.view.MCompras
{
    /// <summary>
    /// Interaction logic for MC_AtenderSolicitudWindow.xaml
    /// </summary>
    public partial class MC_AtenderSolicitudWindow : Window
    {
        public MC_AtenderSolicitudWindow()
        {
            InitializeComponent();
        }

        private void consolidarBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_ConsolidarSolicitudesWindow MCconsolidado = new MC_ConsolidarSolicitudesWindow();
            MCconsolidado.Show();
        }
    }
}
