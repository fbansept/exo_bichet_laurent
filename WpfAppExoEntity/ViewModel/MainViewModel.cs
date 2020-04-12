using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WpfAppExoEntity.DAL;

namespace WpfAppExoEntity.ViewModel
{
    class MainWindowViewModel
    {
        public ICollectionView Personnes { get; private set; }

        public MainWindowViewModel()
        {
        }

      
    }
}
