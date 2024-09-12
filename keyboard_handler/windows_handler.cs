using System.Runtime.InteropServices;
using WindowsInput;

namespace Shade_AI.keyboard_handler
{
    public class Windows_handler
    {
        public static void PressKey(VirtualKeyCode key)
        {
            Console.WriteLine("You pressed: " + key);
            new InputSimulator().Keyboard.KeyDown(key);
        }

        internal static void ReleaseKey(VirtualKeyCode key)
        {
            new InputSimulator().Keyboard.KeyUp(key);
        }
    }

}