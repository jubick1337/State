namespace State
{
    class FinalState : State
    {
        const string notAvailable = "Нельзя сделать это";

        public void ChooseDevice(Context context, string device)
        {
            System.Console.WriteLine(notAvailable);
        }

        public void ChooseDocument(Context context, string document)
        {
            context.Document = document;
            context.State = new DocumentChoiceState();
        }

        public void InsertCash(Context context, int amount)
        {
            System.Console.WriteLine(notAvailable);
        }

        public void PrintDocument(Context context)
        {
            System.Console.WriteLine(notAvailable);
        }

        public void ReturnChange(Context context)
        {
            System.Console.WriteLine("До свидания");
            for (int i = 0; i < context.Cash; i++)
            {
                System.Console.WriteLine("Ваш рубль");
                context.Cash--;
            }
            context.State = new InitState();
        }
    }
}