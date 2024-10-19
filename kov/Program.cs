namespace kov 
{
    class MyExeption : Exception 
    {
        public int ErrorWords { get; }
        public MyExeption(string message) : base(message) { }

      

    }
    class Programm 
    {
        static void Main() 
        {
            Exception[] exceptions = new Exception[]
            {
                new ArgumentException("Базовое исключение 1"),
                new FormatException("Базовое исключение 2"),
                new DivideByZeroException("Базовое исключение 3"),
                new OverflowException("Базовое исключение 4"),
                new MyExeption("Мое исключение")
            };
            foreach(var ex in exceptions)
            try
            {
                    throw ex;
            }
            catch (Exception)
            {
                    Console.WriteLine($"Вызвано исключение{ex.Message}");
            }
             

        }
    }



     
}
 












