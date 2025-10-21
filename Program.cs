namespace LeetCode_2651
{
    internal class Program
    {
        // 主程式進入點
        static void Main(string[] args)
        {

            //C#的輸入與輸出
            //知識點：Ch2 建立C#應用程式，主控台應用程式的輸出與輸入、程式註解、程式碼縮排
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別、字串資料的型別轉換
            //知識點：Ch7 函數，呼叫擁有參數和傳回值的函數、函數的執⾏過程

            Console.WriteLine("Enter ArrivalTime:"); //提示使用者輸入ArrivalTime
            string str1 = Console.ReadLine(); //讀取使用者輸入的字串並存放在str1變數的初值
            int a = Convert.ToInt32(str1); //將str1字串轉換為整數並存放在a變數的初值


            Console.WriteLine("Enter DelayedTime:");  //提示使用者輸入DelayedTime
            string str2 = Console.ReadLine(); //讀取使用者輸入的字串並存放在str2變數的初值
            int b = Convert.ToInt32(str2); //將str1字串轉換為整數並存放在b變數的初值

            Console.WriteLine("The Time:"); //提示使用者輸出結果
            Console.WriteLine(FindDelayedArrivalTime(a, b)); //呼叫擁有參數和傳回值FindDelayedArrivalTime函數並將a與b變數的值傳給形式參數arrivalTime與delayedTime，將傳回值輸出到主控台
            Console.ReadLine(); //等待使用者按下Enter鍵後結束程式

            /*
            LeetCode 2651. Calculate Delayed Arrival Time

            You are given a positive integer arrivalTime denoting the arrival time of a train in hours, and another positive integer delayedTime denoting the amount of delay in hours.
            Return the time when the train will arrive at the station.
            Note that the time in this problem is in 24 - hours format.

            Example 1:
            Input: arrivalTime = 15, delayedTime = 5
            Output: 20
            Explanation: Arrival time of the train was 15:00 hours.It is delayed by 5 hours.Now it will reach at 15 + 5 = 20(20:00 hours).
            Example 2:
            Input: arrivalTime = 13, delayedTime = 11
            Output: 0
            Explanation: Arrival time of the train was 13:00 hours.It is delayed by 11 hours.Now it will reach at 13 + 11 = 24(Which is denoted by 00:00 in 24 hours format so return 0).

            Constraints:
            1 <= arrivaltime < 24
            1 <= delayedTime <= 24

            LeetCode 2651. 計算延誤到達時間

            給定一個正整數 ArrivalTime，表示火車的到達時間（以小時為單位），以及另一個正整數 DelayedTime，表示延誤時間（以小時為單位）。
            返回火車到達車站的時間。
            注意，本題的時間格式為 24 小時制。

            範例 1：
            輸入：arrivalTime = 15, delayedTime = 5
            輸出：20
            解釋：火車的到達時間為 15:00。延誤了 5 小時。現在它將在 15 + 5 = 20（即 20:00）到達。
            範例 2：
            輸入：arrivalTime = 13, delayedTime = 11
            輸出：0
            解釋：列車到達時間為 13:00，晚點 11 小時。現在列車將於 13 + 11 = 24 到達（24 小時制中為 00:00，因此返回 0）。

            限制條件：
            1 <= arrivaltime < 24
            1 <= delayedTime <= 24

            */

            //知識點：Ch7 函數，建立C#函數、函數的參數列、函數的傳回值、區域函數
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別、算術運算⼦

            //解題思路
            //區域函數  1.傳回值是整數資料型別 int  2. 形式變數是兩個整數資料型別 int arrivalTime, int delayedTime
            //1. 回傳值 int 
            int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
            {
                //1.輸入
                //int arrivalTime; 形式變數不用再宣告
                //int delayedTime; 形式變數不用再宣告

                //2.處理
                int time = 0; //宣告一個整數變數並設定初值為0來存放兩數相加的結果
                time = (arrivalTime + delayedTime) % 24; //計算arrivalTime與delayedTime，兩數相加後除以24的餘數，並將結果存放在time變數中

                //3.輸出
                int result; //宣告一個整數變數來存放傳回值
                result = time; //將time變數的值指定給result變數
                return result; //傳回result變數的值
            }
            //結束簽名TMChouys
        }
    }
}
