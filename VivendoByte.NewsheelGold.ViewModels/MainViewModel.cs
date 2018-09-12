using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VivendoByte.NewsheelGold.ViewModels.Service;

namespace VivendoByte.NewsheelGold.ViewModels
{
    public class MainViewModel : ApplicationViewModelBase, IServiceCallback
    {
        public RelayCommand CallCommand { get; set; }

        public ObservableCollection<Department> Items { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private Department selected;
        public Department Selected
        {
            get { return selected; }
            set { selected = value;
                base.RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            this.CallCommand = new RelayCommand(callCommandExecute);
            this.Username = "igor";
            this.Password = "igor";
        }

        private void callCommandExecute()
        {
            StartCommunicationRequest request = new StartCommunicationRequest();
            request.Milliseconds = 25;
            base.client.StartTimer(request);
        }

        public async void SendResult(StartCommunicationResponse response)
        {
            await Task.Run(() => {

                Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
                List<Department> newItems = new List<Department>();
                if (this.Items != null)
                {
                    newItems = this.Items.ToList();
                }

                newItems.AddRange(response.Items);
                this.Items = new ObservableCollection<Department>(newItems);
                base.RaisePropertyChanged(nameof(Items));

                this.Selected = this.Items.LastOrDefault();
            });
        }
    }
}