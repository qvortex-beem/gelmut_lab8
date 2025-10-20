namespace homework
{
    class ValueChecker
    {
        public static void CheckType(object input)
        {

            Type type = input.GetType();
            bool isValue = input is ValueType;
            if (type == typeof(string))
            {
                Console.WriteLine($"Вывод: {(isValue ? "значимый тип" : "ссылочный тип")} (string)");
            }
            if (type == typeof(int))
            {
                Console.WriteLine($"Вывод: {(isValue ? "значимый тип" : "ссылочный тип")} (int)");
            }
        }
    }
}
