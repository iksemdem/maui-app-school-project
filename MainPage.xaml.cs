namespace miau_app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNameTextChanged(object sender, EventArgs ev)
        {
            //newLabel.Text = $"Wprowadzone dane:\nImię: {Name.Text},\nNazwisko: {Surname.Text},\nNumer Telefonu: {PhoneNumber.Text}";
        }

        private void OnNameCompleted(object sender, EventArgs ev)
        {
            //newLabel.Text = $"Wprowadzone dane:\nImię: {Name.Text},\nNazwisko: {Surname.Text},\nNumer Telefonu: {PhoneNumber.Text}";
        }

        private void OnSurnameTextChanged(object sender, EventArgs ev)
        {
            //newLabel.Text = $"Wprowadzone dane:\nImię: {Name.Text},\nNazwisko: {Surname.Text},\nNumer Telefonu: {PhoneNumber.Text}";
        }
        private void OnSurnameCompleted(object sender, EventArgs ev)
        {
            //newLabel.Text = $"Wprowadzone dane:\nImię: {Name.Text},\nNazwisko: {Surname.Text},\nNumer Telefonu: {PhoneNumber.Text}";
        }

        private void OnPhoneNumberTextChanged(object sender, EventArgs ev)
        {
            //newLabel.Text = $"Wprowadzone dane:\nImię: {Name.Text},\nNazwisko: {Surname.Text},\nNumer Telefonu: {PhoneNumber.Text}";
        }
        private void OnPhoneNumberCompleted(object sender, EventArgs ev)
        {
            //newLabel.Text = $"Wprowadzone dane:\nImię: {Name.Text},\nNazwisko: {Surname.Text},\nNumer Telefonu: {PhoneNumber.Text}";
        }
        private void OnButtonSendClicked(object sender, EventArgs ev)
        {
            
            newLabel.Text = $"Wprowadzone dane:\nImię: {Name.Text},\nNazwisko: {Surname.Text},\nNumer Telefonu: {PhoneNumber.Text}";
            
        }

    }

}
