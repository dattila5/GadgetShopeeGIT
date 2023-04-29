﻿using GadgetShopeeManager.ViewModel;
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

namespace GadgetShopeeManager.View
{
    /// <summary>
    /// Interaction logic for GadgetAddWindow.xaml
    /// </summary>
    public partial class GadgetAddWindow : Window
    {
        public GadgetAddVM ViewModel;
        public GadgetAddWindow()
        {
            this.ViewModel = new GadgetAddVM();
            this.DataContext = this.ViewModel;
            InitializeComponent();
        }
    }
}
