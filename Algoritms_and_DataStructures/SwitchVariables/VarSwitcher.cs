namespace Algoritms_and_DataStructures.SwitchVariables
{
    public static class VarSwitcher
    {
        public static void Switch(ref int a, ref int b)
        {
            b = a - b;
            a = a - b;
            b = a + b;
        }
    }
}