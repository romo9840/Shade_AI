using System.Reflection.Metadata.Ecma335;
using System.Security;
using Shade_AI.keyboard_handler;
using WindowsInput;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Handler.InputKey(VirtualKeyCode.LMENU);

    }
}

