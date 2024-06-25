using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayValorant.Interfaces
{
    interface LanguageChangeForgot
    {
        string kullaniciAdinToUsername(Label label);
        string postanToMail(Label label);
        string gonderToSend(Button button);
    }
}
