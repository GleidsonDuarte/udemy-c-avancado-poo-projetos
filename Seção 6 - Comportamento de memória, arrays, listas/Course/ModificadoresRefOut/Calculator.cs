namespace ModificadoresRefOut
{
    class Calculator
    {
        public static void Triplo(ref int x)
        {
            x = x * 3;
        }

        public static void Triplo(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
