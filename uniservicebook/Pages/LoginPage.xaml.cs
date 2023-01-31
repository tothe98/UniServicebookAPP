namespace uniservicebook.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void OnLogin(Object sender, EventArgs e)
	{
		string email = emailTxt.Text;
		string password = passwordTxt.Text;
		if (string.IsNullOrEmpty(email))
		{
			errorLbl.Text = "Az email mezõt kötelezõ kitölteni!";
		}
		if(string.IsNullOrEmpty(password))
		{
			errorLbl.Text = "A jelszó mezõt kötelezõ kitölteni!";
		}

		if(email == "admin" && password == "123") {
			await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
		}
	}
}