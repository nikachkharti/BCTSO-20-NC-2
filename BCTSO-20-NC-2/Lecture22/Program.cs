//ნაკადი

//Thread thread1 = new(() => TimerUp("Timer up"));
//Thread thread2 = new(() => TimerDown("Timer down"));

//thread1.Start();
//thread2.Start();



//void TimerDown(string timerName)
//{
//    for (int i = 10; i >= 1; i--)
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine($"{timerName}: {i}");
//    }
//}

//void TimerUp(string timerName)
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine($"{timerName}: {i}");
//    }
//}





//int counter = 0;

////.NET 8 -
////object incrementLocker = new();

////.NET 9 +
//Lock incrementLocker = new();

//Thread thread1 = new(IncrementCounter);
//thread1.Name = "First Thread";

//Thread thread2 = new(IncrementCounter);
//thread2.Name = "Second Thread";

//thread1.Start();
//thread2.Start();

//thread1.Join();
//thread2.Join();

//Console.WriteLine($"Final counter value is: {counter}");


//void IncrementCounter()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        #region LOCK
//        //lock (incrementLocker)
//        //{
//        //    int temp = counter;
//        //    counter = temp + 1;
//        //} 
//        #endregion


//        #region MONITOR

//        //try
//        //{
//        //    Monitor.Enter(incrementLocker);
//        //    int temp = counter;
//        //    counter = temp + 1;
//        //}
//        //finally
//        //{
//        //    Monitor.Exit(incrementLocker);
//        //}

//        #endregion


//        //MUTEX


//        //SEMAPHORE
//    }
//}







int counter = 0;

ReaderWriterLockSlim incrementLocker = new ReaderWriterLockSlim();

Thread thread1 = new(IncrementCounter);
thread1.Name = "First Thread";

Thread thread2 = new(IncrementCounter);
thread2.Name = "Second Thread";

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

Console.WriteLine($"Final counter value is: {counter}");




//READER WRITE LOCK
void IncrementCounter()
{
    for (int i = 0; i < 100000; i++)
    {
    #region READ/WRITE LOCK

    try
    {
        incrementLocker.EnterWriteLock();
        int temp = counter;
        counter = temp + 1;
    }
    finally
    {
        incrementLocker.ExitWriteLock();
    }
    #endregion
}
}