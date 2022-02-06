namespace M2HW3
{
    using System;

    internal static class ExtensionClass
    {
        public static void Find(this Chocolate[] chocolates, Predicate<Chocolate> match)
        {
            foreach (var chocolate in chocolates)
            {
                if (match(chocolate))
                {
                    Console.WriteLine($"Найдена конфета весом больше ста грамм : {chocolate.Type()}");
                }
            }
        }
    }
}
