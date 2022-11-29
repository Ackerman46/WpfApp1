namespace WpfApp1
{
    internal class Triad
    {
        protected int _one, _two, _three;

        public int One { get { return _one; } set { _one = value; } }
        public int Two { get { return _two; } set { _two = value; } }
        public int Three { get { return _three; } set { _three = value; } }

        /// <summary>
        /// Сравнивает две тройки между собой
        /// </summary>
        /// <param name="triad1">Первая тройка</param>
        /// <param name="triad2">Вторая тройка</param>
        /// <returns>true, если две тройки равны, false, если две тройки не равны</returns>
        public bool CompareTriad(Triad triad1, Triad triad2)
        {
            return triad1.One == triad2.One && triad1.Two == triad2.Two && triad1.Three == triad2.Three;
        }
        /// <summary>
        /// Сложение тройки на число пользователя
        /// </summary>
        /// <param name="userValue">Число пользователя</param>
        /// <param name="triad1">Тройка чисел</param>
        /// <returns>Сумма тройки</returns>
        public Triad SumOfNum(int userValue, Triad triad1)
        {
            Triad triad3 = new Triad();
            triad3.One = triad1.One + userValue;
            triad3.Two = triad1.Two + userValue;
            triad3.Three = triad1.Three + userValue;
            return triad3;
        }
        /// <summary>
        /// Усножение тройки на число пользователя
        /// </summary>
        /// <param name="userValue">Число пользователя</param>
        /// <param name="triad1">Тройка чисел</param>
        /// <returns>Произведение тройки</returns>
        public Triad PowOfNum(int userValue, Triad triad1)
        {
            Triad triad3 = new Triad();
            triad3.One = triad1.One * userValue;
            triad3.Two = triad1.Two * userValue;
            triad3.Three = triad1.Three * userValue;
            return triad3;
        }
        /// <summary>
        /// Сложение двух троек
        /// </summary>
        /// <param name="triad1">Первая тройка</param>
        /// <param name="triad2">Вторая тройка</param>
        /// <returns>Сумму двух троек</returns>
        public Triad SumOfNum(Triad triad1, Triad triad2)
        {
            Triad triad3 = new Triad();
            triad3.One = triad1.One + triad2.One;
            triad3.Two = triad1.Two + triad2.Two;
            triad3.Three = triad1.Three + triad2.Three;
            return triad3;
        }
    }
}
