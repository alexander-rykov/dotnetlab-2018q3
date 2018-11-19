using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var closuresTask = new Worker();

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var input = Enumerable.Range(1, 100);
            closuresTask.Start(input); // start worker

            stopWatch.Stop();
            var elapsed = stopWatch.Elapsed;
            var elapsedTime = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds / 10:00}";

            Console.WriteLine($"Required time: {elapsedTime}");
        }
    }

    public class Worker
    {
        private object _lock = new object();

        public void Start(IEnumerable<int> inputValues)
        {
            var lockObject = new object();
            var aggregateResult = new BatchResult();

            Parallel.ForEach(inputValues, item => {
                try {
                    HardRemoteWorker.HardWork(item);
                } catch (Exception ex) {
                    lock (lockObject) {
                        aggregateResult.AddError(ex.Message);
                    }
                }
            });

            if (aggregateResult.Success == false) {
                Console.WriteLine(string.Join("\n", aggregateResult.Errors));
            }
        }
    }

    public static class HardRemoteWorker
    {
        public static Random Random = new Random();

        public static void HardWork(int item)
        {
            // processing the item (e.g. sending its value to the specified service)

            // Imitation of hard work (e.g. call to remote service to get some data)
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var value = Random.Next(1, 10);
            if (value > 6) {
                throw new Exception($"Processing item \"{item}\" failed cause random value is {value}.");
            }
        }
    }
}
