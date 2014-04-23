using System.Runtime.InteropServices;

namespace MutableArray
{
    [StructLayout(LayoutKind.Explicit)]
    public class ArrayHack
    {
        [FieldOffset(0)]
        public ArrayHacker Hacker;
        [FieldOffset(0)]
        public int[] Array = new int[2];
    }
}