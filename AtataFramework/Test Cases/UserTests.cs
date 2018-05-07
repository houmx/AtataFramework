using Atata;
using AtataFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataFramework.Test_Cases
{
    class UserTests: UITestFixture
    {
        [Test]
        public void User_Create()
        {
            string firstName = "hmx"; 
            string lastName = "Hou";
            string email = "mxou19@gmail.com";
            Office office = Office.NewYork;
            Gender gender = Gender.Male;

            Login().   //return UserPages
                New.ClickAndGo().   //return UserEditWindow
                    ModalTitle.Should.Equal("New User").
                    General.FirstName.Set(firstName).
                    General.LastName.Set(lastName).
                    General.Email.Set(email).
                    General.Office.Set(office).
                    General.Gender.Set(gender).
                    Save.ClickAndGo().   //return UsersPage

                Users.Rows[x => x.FirstName == firstName &&
                    x.LastName == lastName].View.ClickAndGo().      // Returns UserDetailsPage.
                    Name.Should.Equal($"{firstName} {lastName}").
                    Email.Should.Equal(email).
                    Office.Should.Equal(office).
                    Gender.Should.Equal(gender).
                    Birthday.Should.Not.Exist().
                    Notes.Should.Not.Exist();

        }
    }
}
