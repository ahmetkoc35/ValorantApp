using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayValorant.Interfaces
{
    interface LanguageChangesPasswordChange
    {

        string eskiToOld(Label label);
        string yeniToNew(Label label);
        string tekrarToCheck(Label label);
        string degistirToChange(Button button);

    }
}
