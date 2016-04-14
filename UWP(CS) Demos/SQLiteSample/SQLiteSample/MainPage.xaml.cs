using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SQLiteSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new BloggingContext())
            {
                Blogs.ItemsSource = db.Blogs.ToList();
            }
        }

        private async void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            AddItemDialog dialog = new AddItemDialog();
            await dialog.ShowAsync();

            if (dialog.Result == AddItemResult.SUCCESS)
            {
                using (var db = new BloggingContext())
                {
                    var blog = new Blog { Url = dialog.ItemContent };
                    db.Blogs.Add(blog);
                    db.SaveChanges();
                    Blogs.ItemsSource = db.Blogs.ToList();
                }
            }
        }
    }
}
