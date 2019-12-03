using System;
namespace State
{
    public class Context
    {

        private readonly State state;
        private readonly string document;
        private readonly string device;
        private readonly int cash;

        public void InsertCash(int cash) => state.InsertCash(this, cash);
        public void ChooseDevice(string device) => state.ChooseDevice(this, device);
        public void ChooseDocument(string document) => state.ChooseDocument(this, document);
        public void PrintDocument() => state.PrintDocument(this);
        public void ReturnChange() => state.ReturnChange(this);

    }
}
