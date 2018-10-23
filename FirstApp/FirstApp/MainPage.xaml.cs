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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FirstApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string _username = "";
        private string _password = "";
        private BankingSystem _bankingSystem = new BankingSystem();
        public MainPage()
        {

            
            this.InitializeComponent();
        }
     
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            _username = this.TextBoxUsername.Text;
            _password = this.TextBoxPassword.Text;

            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await
                synth.SynthesizeTextToStreamAsync(_username);
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();

            LoginUser();
        }
       
        private void LoginUser()
        {
            foreach (User u in _bankingSystem.Users)
            {
                if ((_username.ToLower() == u.Username.ToLower()) && _password.ToLower() == u.Password.ToLower())
                {
                    this.Frame.Navigate(typeof(HomeScreen));
                }
            }

            
        }

        public void AddUser(User user)
        {
            _bankingSystem.Users.Add(user);
        }
        private void CreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NewUser));
        }

        public BankingSystem BankManagementSystem
        {
            get
            {
                return _bankingSystem;
            }
        }
    }
}
