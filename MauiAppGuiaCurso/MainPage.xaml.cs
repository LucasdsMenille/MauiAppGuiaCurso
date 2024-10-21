namespace MauiAppGuiaCurso
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void pri_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.primeiro.Mainprimeiro());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }


        }

        private void seg_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new MauiAppGuiaCurso.categorias.segundo.Mainsegundo());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void ter_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.terceiro.Mainterceiro());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

      
    }

}
