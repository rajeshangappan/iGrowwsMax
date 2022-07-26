using System.Threading.Tasks;
using System.Windows.Input;
using ValidationsDemo.Model;
using Xamarin.Forms;

namespace ValidationsDemo.ViewModel
{
    public class MainPageViewModel
    {
        public LoginModel LoginModel { get; set; } = new LoginModel();
        public ICommand LoginInCommand { get; }
        private Page _page;
        public MainPageViewModel(Page page)
        {
            _page = page;
            LoginInCommand = new Command(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            if (!ValidationHelper.IsFormValid(LoginModel, _page)) { return; }
            await _page.DisplayAlert("Login", "Success!", "OK");
           
        }
    }
}