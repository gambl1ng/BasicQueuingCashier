using System;
using System.Collections.Generic;

namespace BasicQueuingCashier
{
    public sealed class CashierClass
    {
        private int x;
        public Queue<string> CashierQueue { get; private set; }

        public event Action<Queue<string>> OnQueueUpdated;

        private static readonly CashierClass instance = new CashierClass();

        private CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }

        public static CashierClass Instance
        {
            get { return instance; }
        }

        public string CashierGeneratedNumber(string prefix)
        {
            x++;
            string newQueueNumber = prefix + x.ToString();
            CashierQueue.Enqueue(newQueueNumber);
            OnQueueUpdated?.Invoke(this.CashierQueue);
            return newQueueNumber;
        }

        public string Dequeue()
        {
            if (CashierQueue.Count > 0)
            {
                string servedNumber = CashierQueue.Dequeue();
                OnQueueUpdated?.Invoke(this.CashierQueue);
                return servedNumber;
            }
            return null;
        }
    }
}