using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlayValorant.Interfaces
{
    class Implementation : LanguageChangeLogIn, LanguageChangeUserMain, LanguageChangesPasswordChange, 
                           LanguageChangeSignUp, LanguageChangeForgot
    {

        //------------------------------------------------------------------------------------------
        //----------------------------------- Log In Page ------------------------------------------
        //------------------------------------------------------------------------------------------
        public string arayuzToInterface(Label label)
        {
            return label.Text = "Valorant Tournaments\nInterface";
        }

        public string kullanıcıAdıToUsername(Label label)
        {
            return label.Text = "E MaIl";
        }

        public string cikisToExit(Button button)
        {
            return button.Text = "ExIt";
        }

        public string girisToLogIn(Button button)
        {
            return button.Text = "Log In";
        }

        public string gosterToShow(CheckBox checkBox)
        {
            return checkBox.Text = "Show";
        }

        public string sifreToPassword(Label label)
        {
            return label.Text = "Password";
        }

        public string unuttunToForgot(LinkLabel linkLabel)
        {
            return linkLabel.Text = "Forgot Your\nPassword";
        }

        public string uyeOlToSignUp(Button button)
        {
            return button.Text = "SIgn Up";
        }

        //------------------------------------------------------------------------------------------
        //----------------------------------- User Main Page ---------------------------------------
        //------------------------------------------------------------------------------------------

        public string VpsAlToBuy(Button button)
        {
            return button.Text = "Buy VPS";
        }

        public string VpAlToBuy(Button button)
        {
            return button.Text = "Buy VP"; 
        }

        public string kacToMany(Button button)
        {
            return button.Text = "How Many VPS Do I Have?";
        }

        public string katilToJoin(Button button)
        {
            return button.Text = "Join Our Discord Server";
        }

        public string takipToFollow(Button button)
        {
            return button.Text = "Follow Our Instagram Account";
        }

        public string turnuvaToTournament(Button button)
        {
            return button.Text = "Watch Live Tournaments";
        }

        public string gitToOpen(Button button)
        {
            return button.Text = "Go To The Website";
        }

        public string iletisimToContact(Button button)
        {
            return button.Text = "Contact Us";
        }

        public string sifreToPassword(Button button)
        {
            return button.Text = "Change Password";
        }

        public string geriToBack(Button button)
        {
            return button.Text = "Back";
        }

        //------------------------------------------------------------------------------------------
        //----------------------------------- Change Password --------------------------------------
        //------------------------------------------------------------------------------------------
        public string eskiToOld(Label label)
        {
            return label.Text = "Your Current Password";
        }

        public string yeniToNew(Label label)
        {
            return label.Text = "Your New Password";
        }

        public string tekrarToCheck(Label label)
        {
            return label.Text = "Your New Password Again";
        }

        public string degistirToChange(Button button)
        {
            return button.Text = "Change Password";
        }

        //------------------------------------------------------------------------------------------
        //----------------------------------- Sign Up Page -----------------------------------------
        //------------------------------------------------------------------------------------------

        public string postaToMail(Label label)
        {
            return label.Text = "E-Mail";
        }

        public string kaydolToSignUp(Button button)
        {
            return button.Text = "Sign Up";
        }

        public string tekrarToAgain(Label label)
        {
            return label.Text = "Your Password Again";
        }

        //------------------------------------------------------------------------------------------
        //----------------------------------- Forgot Password --------------------------------------
        //------------------------------------------------------------------------------------------

        public string kullaniciAdinToUsername(Label label)
        {
            return label.Text = "Your Username";
        }

        public string postanToMail(Label label)
        {
            return label.Text = "Your E-Mail";
        }

        public string gonderToSend(Button button)
        {
            return button.Text = "Send";
        }
    }
}
