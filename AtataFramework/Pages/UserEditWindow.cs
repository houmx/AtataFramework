using Atata;
using Atata.Bootstrap;



namespace AtataFramework.Pages
{

    using _ = UserEditWindow;

    public class UserEditWindow : BSModal<_> 
    {
        [FindById("general")]
        public GeneralTabPane General { get; private set; }

        [FindById("additional")]
        public AdditionalTabPane  Additional { get; private set; }

        [FindByContent]
        [Term("Create","Save")]
        public Button<UsersPage, _>  Save { get; private set; }


        public class GeneralTabPane: BSTabPane<_>
        {
            public TextInput<_> FirstName { get; private set; }
            public TextInput<_> LastName { get; private set; }
            public TextInput<_> Email { get; private set; }

            [FindById("office")]
            public Select<Office, _> Office { get; private set; }

            [FindByName("gender")]
            public RadioButtonList<Gender,_> Gender { get; private set; }

        }
        public class AdditionalTabPane: BSTabPane<_>
        {
            public DateInput<_> Birthday { get; private set; }
            public TextArea<_> Notes { get; private set; }

        }


    }
}
