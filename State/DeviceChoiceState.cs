namespace State
{
    public class DeviceChoiceState : State
    {
        const string notAvailable = "Нельзя сделать это";

        public void ChooseDevice(Context context, string device)
        {
            context.Device = device;
            context.State = ;
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
            System.Console.WriteLine(notAvailable);
        }

        public void ReturnChange(Context context)
        {
            System.Console.WriteLine(notAvailable);
        }
    }
}