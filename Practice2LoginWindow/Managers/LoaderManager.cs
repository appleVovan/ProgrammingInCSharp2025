using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Managers
{
    internal class LoaderManager
    {
        private static LoaderManager _instance;

        public static LoaderManager Instance
        {
            get
            {
                return _instance ??= new LoaderManager();
            }
        }

        private LoaderManager()
        {
            
        }
    }
}
