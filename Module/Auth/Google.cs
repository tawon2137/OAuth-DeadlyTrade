namespace AuthDeadlyTrade.Provider.Auth
{
    public class GoogleModule: IAuthModule
    {   
        static string PROVIDER = "google";

        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _callbackUri;

        public GoogleModule(string clientId, string clientSecret, string _callbackUri) {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _callbackUri = _callbackUri;
        }


        public async void Auth() {
            
        }

        

    }   
}