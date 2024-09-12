using System.Runtime.InteropServices;
using WindowsInput;

namespace Shade_AI.keyboard_handler
{
    public class Mac_handler
    {
        public static void PressKey(VirtualKeyCode key)
        {
            Console.WriteLine("You pressed: " + key);

        }

    }

}