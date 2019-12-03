using System;

namespace State
{
    interface State
    {
        void InsertCash();
        void ChooseDevice();
        void ChooseDocument();
        void PrintDocument();
        void ReturnChange();
    }
}
