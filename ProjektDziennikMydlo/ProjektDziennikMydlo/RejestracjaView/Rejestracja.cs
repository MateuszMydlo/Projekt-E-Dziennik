namespace ProjektDziennikMydlo.RejestracjaView
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void buttonDodajUcznia_Click(object sender, EventArgs e)
        {
            var rejestracjaUzupełnianie = new RejestracjaUzupełnienieDanych();
            rejestracjaUzupełnianie.MyEvent += childForm_MyEvent;
            rejestracjaUzupełnianie.Show();

        }

        private void childForm_MyEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Child form event triggered.");
        }

        public void HandleSomeEvent(object sender, EventArgs e)
        {
            Console.WriteLine("aaa");
        }
    }
}
