﻿using MatrizenRechner.ViewModel;
using System;
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

namespace MatrizenRechner
{
    /// <summary>
    /// Interaktionslogik für MatrizenRechnerMW.xaml
    /// </summary>
    public partial class MatrizenRechnerMW : Window
    {
        public MatrizenRechnerMW()
        {
            InitializeComponent();
            this.DataContext = new MatrizenRechnerViewModel();
        }
    }
}