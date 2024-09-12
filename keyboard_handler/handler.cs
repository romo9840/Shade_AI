using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WindowsInput;

namespace Shade_AI.keyboard_handler
{
    public class Handler
    {
        private static void PressKey(VirtualKeyCode key)
        {
            if (GetOS() == OSPlatform.OSX)
            {
                Mac_handler.PressKey(key);
            }
            if (GetOS() == OSPlatform.Windows)
            {
                Windows_handler.PressKey(key);

            }
        }
        private static void ReleaseKey(VirtualKeyCode key)
        {
            if (GetOS() == OSPlatform.OSX)
            {
                Mac_handler.PressKey(key);
            }
            if (GetOS() == OSPlatform.Windows)
            {
                Windows_handler.ReleaseKey(key);

            }
        }
        public static void InputKey(VirtualKeyCode key)
        {
            PressKey(key);
            ReleaseKey(key);
        }

        private static OSPlatform GetOS()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return OSPlatform.OSX;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return OSPlatform.Windows;
            }
            else
            {
                return OSPlatform.Linux;
            }

        }
    }
}