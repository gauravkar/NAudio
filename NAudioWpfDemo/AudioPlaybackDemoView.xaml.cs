﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NAudioWpfDemo
{
    /// <summary>
    /// Interaction logic for AudioPlaybackDemo.xaml
    /// </summary>
    public partial class AudioPlaybackDemoView : UserControl
    {
        ControlPanelViewModel viewModel;

        public AudioPlaybackDemoView()
        {
            InitializeComponent();

        }
    }
}