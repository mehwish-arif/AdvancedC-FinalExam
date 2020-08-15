using System;
using System.Collections;
using System.Collections.Generic;

namespace Event_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            DataPushOperation<string> Data = new DataPushOperation<string>();
            var Push = new PushOperation();

            Data.datapush += Push.onPushData;

            Data.pushdata("mehwish");
            Data.pushdata("Arif");
            Data.pushdata("Eshaal");
            Data.pushdata("Rayan");

            Console.WriteLine();
        }
    }

    public class PushOperation
    {
        public void onPushData(object source, EventArgs e)
        {
            Console.WriteLine("Item is added to the Queue");
        }

    }

    public class DataPushOperation<T> : EventArgs
    {
        public delegate void PushEventHandler(object source, EventArgs e);

        public event PushEventHandler datapush;

        private Queue<T> q = new Queue<T>();

        public void pushdata(T item)
        {
            q.Enqueue(item);
            onPushData();
        }

        protected virtual void onPushData()
        {
            if (datapush != null)
                datapush(this, EventArgs.Empty);
        }
    }
}
