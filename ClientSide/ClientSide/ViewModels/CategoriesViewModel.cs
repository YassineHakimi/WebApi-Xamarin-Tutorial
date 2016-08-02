using ClientSide.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Plugin.RestClient;
namespace ClientSide.ViewModels
{
    public class CategoriesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IList<Category> _categories;
        public IList<Category> Categories
        {
            get { return _categories; }
            set { _categories = value;
                OnPropertyChanged();
            }
        }

        public CategoriesViewModel()
        {
            InitData();
        }

        //initialize the list
        public async void InitData()
        {
            Categories = await new RestClient<Category>().GetAsync();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
