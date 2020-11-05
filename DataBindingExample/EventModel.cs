using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBindingExample
{
    class Evento : INotifyPropertyChanged
    {
        private string title;
        private DateTime date;
        private string propertyName;

        public string Title
        {
            get => title;
            set
            {
                if (value != title)
                {
                    title = value;
                    OnPropertyChanged(title);

                }
            }
        }

       

        public DateTime Date
        {
            get => date;
            set
            {
                if(value != date)
                {
                    date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string title)
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            
        }
    }
}
