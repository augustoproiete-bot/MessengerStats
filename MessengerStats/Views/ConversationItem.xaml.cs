﻿using System;
using System.Collections.Generic;
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

namespace MessengerStats.Views {
    /// <summary>
    /// Interaction logic for ConversationItem.xaml
    /// </summary>
    public partial class ConversationItem : UserControl {
        public ConversationItem() {
            InitializeComponent();
        }
        public ConversationItem(string name) {
            InitializeComponent();
            ConvName.Text = name;
        }
    }
}
