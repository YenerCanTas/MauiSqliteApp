namespace MauiSqliteApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        }

        private void Buton_Add_Clicked(object sender, EventArgs e)
        {
            App.DBTrans.Add(new Models.StudentClass
            {
                Name = Stu_Name.Text,
                Department = Stu_Dept.Text,
                Number = Stu_Number.Text
            });
            Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        }

        private void Delete_Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            App.DBTrans.Delete((int)button.BindingContext);
            Stu_List_View.ItemsSource= App.DBTrans.GetAllStudents();    
        }

        private void Button_Show_Clicked(object sender, EventArgs e)
        {
            Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
        }
    }

}
