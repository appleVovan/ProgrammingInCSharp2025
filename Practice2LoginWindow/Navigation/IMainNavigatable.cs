﻿using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation
{
    interface IMainNavigatable
    {
        public MainNavigationType ViewModelType { get; }
    }
}
