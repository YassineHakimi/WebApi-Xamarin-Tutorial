using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSide.ViewModels;
using Xamarin.Forms;
using ClientSide.Models;
namespace ClientSide.Pages
{
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
            BindingContext = new CategoriesViewModel();
            CategoryList.ItemTapped += CategoryList_ItemTapped;
        }

        private void CategoryList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Category;
            var sections = item.Sections;
            var SectionsPage = new SectionsPage(sections);
            Navigation.PushAsync(SectionsPage);
        }
    }
}
