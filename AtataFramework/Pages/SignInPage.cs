using Atata;

namespace AtataFramework
{
    using Pages;
    using _ = SignInPage;

    [Url("signin")]  // Relative URL of the page.
    [VerifyTitle]
    [VerifyH1]
    public class SignInPage : Page<_>
    {
        [FindById("email")]
        public TextInput<_> Email { get; private set; }

        [FindById("password")]
        public PasswordInput<_> Password { get; private set; }

        [FindByClass("btn btn-primary")]
        public Button<UsersPage,_> SignIn { get; private set; }
    }
}