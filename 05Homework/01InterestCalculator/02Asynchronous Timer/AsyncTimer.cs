using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _02Asynchronous_Timer
{
    public delegate void ChangedEventHandler(object sender, EventArgs e);
    class AsyncTimer
    {
        private Action 
        public Timer Timer1 = new Timer(Console.WriteLine, null, 0, 10);
        public AsyncTimer() 
        { 
        }

    }
}
