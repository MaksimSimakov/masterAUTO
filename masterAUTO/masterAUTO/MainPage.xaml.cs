using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace masterAUTO
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("bmw.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.bmw);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        private List<MasterMenuItems> GetMenuList()
        {
            
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "BMW",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "bmwlogo.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Audi",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "audi.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mercedes",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "merc.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Volkswagen",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "volks.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Toyota",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "toyota.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Nissan",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "nissan.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mini",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "mini.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Saab",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "saab.png",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Volvo",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "volvo.jpg",
                TargetPage = typeof(Views.bmw)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Lada",
                Detail = "Модель, двигатель, Цена",
                ImagePath = "lada.jpg",
                TargetPage = typeof(Views.bmw)

            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
