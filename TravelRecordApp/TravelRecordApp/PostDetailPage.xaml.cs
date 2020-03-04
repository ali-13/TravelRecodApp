using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostDetailPage : ContentPage
    {
        Post selectedPost;
        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();

           this.selectedPost = selectedPost;

            experienceEntry.Text = selectedPost.Experience;
        }

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {

                connection.CreateTable<Post>();
                int rows = connection.Update(selectedPost);

                if (rows > 0)
                    DisplayAlert("Succes", "Experience succesfully updated", "Ok");
                else DisplayAlert("Succes", "Experience succesfully updated", "Ok");
            }
        }

        private void DeletButton_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {

                connection.CreateTable<Post>();
                int rows = connection.Delete(selectedPost);

                if (rows > 0)
                    DisplayAlert("Succes", "Experience succesfully deleted", "Ok");
                else DisplayAlert("Succes", "Experience succesfully deleted", "Ok");
            }
        }
    }
}