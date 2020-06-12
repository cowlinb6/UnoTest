using IdentityModel.Client;
using IdentityModel.OidcClient;
using Plum.Common;
using PlumTest.Shared.ViewModels;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PlumTest.Shared.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginView : Page
    {
        OidcClient _oidcClient;
        LoginResult _loginResult;
        HttpClient _httpClient;

        public LoginViewModel ViewModel { get; set; }
        

        public LoginView()
        {
            ViewModel = new LoginViewModel();

            InitializeComponent();            

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.ApiUri);
        }

        private async void Login_OnClick(object sender, RoutedEventArgs e)
        {
            var options = new OidcClientOptions
            {
                Authority = Constants.AuthorityUri,
                ClientId = Constants.ClientId,
                Scope = Constants.Scope,
                RedirectUri = Constants.RedirectUri,
                ResponseMode = OidcClientOptions.AuthorizeResponseMode.Redirect,
                Browser = new Browser(),
                Policy = new Policy { Discovery = new DiscoveryPolicy { RequireHttps = false } }
            };

            _oidcClient = new OidcClient(options);
            _loginResult = await _oidcClient.LoginAsync(new LoginRequest());

            if (_loginResult.IsError)
            {
                ViewModel.Result = $"Error: {_loginResult.Error}";
                return;
            }

            ViewModel.Result = "Success";
            ViewModel.IdentityToken = _loginResult.IdentityToken;
            ViewModel.AccessToken = _loginResult.AccessToken;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _loginResult?.AccessToken ?? string.Empty);

            var response = await _httpClient.GetAsync("");
            var content = await response.Content.ReadAsStringAsync();
            ViewModel.UserInfo = content;

        }

    }
}
