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
        private static readonly object _locker = new object();

        public static LoaderManager Instance
        {
            get
            {
                if (_instance !=null)
                {
                    return _instance;
                }
                lock (_locker)
                {
                    return _instance ??= new LoaderManager();
                }
            }
        }

        private LoaderManager()
        {
            
        }

        public void ShowLoader()
        {

        }

        public void HideLoader()
        {

        }
    }
}
