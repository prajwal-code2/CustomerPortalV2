namespace CustomerPortalV2.Web.Data
{
    public class UserSession
    {
        public string? LoggedInUser { get; private set; }

        public void Login(string username)
        {
            LoggedInUser = username;
        }

        public void Logout()
        {
            LoggedInUser = null;
        }

        public bool IsAuthenticated => !string.IsNullOrEmpty(LoggedInUser);
        public string Username => LoggedInUser ?? "";
    }
}
