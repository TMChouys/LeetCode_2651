namespace LeetCode_2651
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter ArrivalTime:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DelayedTime:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The Time:");
            Console.WriteLine(FindDelayedArrivalTime(a, b));

            //LeetCode 2651. Calculate Delayed Arrival Time
            //1. 回傳值 int 
            int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
            {
                //1.輸入
                //int arrivalTime;
                //int delayedTime;

                //2.處理
                int time;
                time = (arrivalTime + delayedTime) % 24;

                //3.輸出
                int result;
                result = time;
                return result;
            }
        }
    }
}
