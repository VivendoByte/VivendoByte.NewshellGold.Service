using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VivendoByte.NewsheelGold.ViewModels.Service;

namespace VivendoByte.NewsheelGold.ViewModels
{
    public class ApplicationViewModelBase : ViewModelBase
    {
        InstanceContext context;
        protected ServiceClient client;

        public ApplicationViewModelBase()
        {
            context = new InstanceContext(this);
            client = new ServiceClient(context);
        }
    }
}