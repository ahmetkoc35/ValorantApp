using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayValorant.Interfaces
{
    interface LanguageChangeLogIn
    {

        string arayuzToInterface(Label label);
        string kullanıcıAdıToUsername(Label label);
        string sifreToPassword(Label label);
        string gosterToShow(CheckBox checkBox);
        string girisToLogIn(Button button);
        string unuttunToForgot(LinkLabel linkLabel);
        string uyeOlToSignUp(Button button);
        string cikisToExit(Button button);
    }
}
