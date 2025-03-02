﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace Project
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            frame.Navigate(typeof(HomePage), "");
        }
        bool Login = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mySplit.IsPaneOpen = !mySplit.IsPaneOpen;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SymbolIcon a = (SymbolIcon)(((Grid)e.ClickedItem).Children[0]);
            if (a.Name == "HomePage")
            {
                if (!Login) frame.Navigate(typeof(LoginPage), "");
                else frame.Navigate(typeof(HomePage), "");
            }
            else if (a.Name == "AddTask") frame.Navigate(typeof(AddTaskPage), "");
            else frame.Navigate(typeof(TaskListPage), "");
        }
    }
}
