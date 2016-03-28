using System.Collections;
using System.Windows.Forms;

namespace Sciencetific_Calc
{
    class Input
    {
        private static Hashtable keytable = new Hashtable();

        public static bool KeyPressed(Keys key)
        {
            if (keytable[key] == null)
            {
                return false;
            }

            return (bool)keytable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            keytable[key] = state;
        }
    }
}
