namespace treminarz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        
        static string[] tytul = { "tytuł1","tytuł2", "tytuł3" };
        static string[] opis = { "opisowyopis1", "opisowyopis2", "opisowyopis3" };
        static string[] data = { "2025-01-01", "2015-02-02", "2005-03-03" };
        static string[] godzina = { "1:40", "2:40", "3:40" };
        static int ile = tytul.Length;
        public MainPage()
        {
            
            InitializeComponent();
            zmiana();
        }
        private void zmiana()
        {
            tyt.Text = tytul[count];
            ops.Text = opis[count];
            dat.Text = data[count];
            god.Text = godzina[count];
        }
        private void OnNas(object? sender, EventArgs e)
        {
            count++;
            if (count == ile)
            {
                count = 0;
            }
            zmiana();
        }
        private void OnPop(object? sender, EventArgs e)
        {
            count--;
            if (count == -1)
            {
                count = ile-1;
            }
            zmiana();
        }
    }
}
