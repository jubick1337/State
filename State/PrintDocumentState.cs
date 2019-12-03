namespace State
{
    class PrintDocumentState : State
    {
        const string notAvailable = "Нельзя сделать это";

        public void ChooseDevice(Context context, string device)
        {
            System.Console.WriteLine(notAvailable);
        }

        public void ChooseDocument(Context context, string document)
        {
            System.Console.WriteLine(notAvailable);
        }

        public void InsertCash(Context context, int amount)
        {
            System.Console.WriteLine(notAvailable);
        }

        public void PrintDocument(Context context)
        {
            throw new System.NotImplementedException();
        }

        public void ReturnChange(Context context)
        {
            System.Console.WriteLine(notAvailable);
        }
    }
}