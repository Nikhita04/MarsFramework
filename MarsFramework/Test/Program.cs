using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void Test()
            {
                SignUp S = new SignUp();
                S.register();
                SignIn Si = new SignIn();
                Si.LoginSteps();
                ShareSkill r = new ShareSkill();
                r.EnterShareSkill();
                Profile P = new Profile();
                P.EditProfile();
                ManageListings M = new ManageListings();
                M.Listings();

            }



        }
    }
}