﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace dungeon
{
    internal class Navigation
    {
        public static bool IsAutorizate = false;
        public static Client AuthorizateUser;
        public static MainWindow main;
        public static void Update(Page page)
        {
            main.MyFrame.Navigate(page);
        }
    }
}
