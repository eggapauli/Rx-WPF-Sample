﻿using System;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Windows;

namespace WpfRxSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += (s, e) => DataContext = new MainViewModel();
            Closed += (s, e) => ((MainViewModel)DataContext).Dispose();
        }
    }
}
