namespace AuthDeadlyTrade.Provider.Auth
{
    public class GoogleModule: IAuthModule
    {   
        static string Provider = "google";
        static string CallbackUri = "";
        private readonly string _clientId;
        private readonly string _clientSecret;
        public GoogleModule(string clientId, string clientSecret) {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }


        public async void Auth() {
            
        }

        

    }   
}