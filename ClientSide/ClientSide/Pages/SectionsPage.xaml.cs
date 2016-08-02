using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSide.Models;
using ClientSide.ViewModels;
using Xamarin.Forms;

namespace ClientSide.Pages
{
    public partial class SectionsPage : ContentPage
    {
        public SectionsPage(ICollection<Section> sections)
        {
            InitializeComponent();
            SectionsList.ItemsSource = sections;
        }
    }
}
