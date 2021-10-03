using System.Linq;
using System.Windows.Forms;

namespace DecryptApp
{
    public static class InputSetup
    {
        const string allowedChar = "abcdefghijklmnopqrstuvwxyz ";

        public static bool IsAllowed(KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (!allowedChar.Any(chr => chr == char.ToLower(e.KeyChar)))
                {
                    e.Handled = true;
                    return true;
                }
            }

            e.Handled = false;

            return false;
        }
    }
}
