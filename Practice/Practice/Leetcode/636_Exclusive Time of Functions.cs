using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _636_Exclusive_Time_of_Functions
    {
        public static void Main(string[] args)
        {
            List<string> logs = new List<string>();
            logs.Add("0:start: 0");
            logs.Add("0:start: 2");
            logs.Add("0:end: 5");
            logs.Add("0:start:6");
            logs.Add("0:end:6");
            logs.Add("0:end:7");
            _636_Exclusive_Time_of_Functions a = new _636_Exclusive_Time_of_Functions();
            int[] result = a.ExclusiveTime(2, logs);
        }
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            List<int> result = new List<int>();
            int countTimeSoFar = 0;
            
            function[] tasks = new function[logs.Count];
            for (int i = 0; i < logs.Count; i++)
            {
                string[] temp = logs[i].Split(':');
                tasks[i] = new function(Int32.Parse(temp[0]), temp[1], Int32.Parse(temp[2]));
                
            }
            Stack<function> st = new Stack<function>();
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].status == "start")
                    st.Push(tasks[i]);
                else if(tasks[i].status =="end" && st.Peek().FunctionID == tasks[i].FunctionID)
                {
                    int countThisTask = 0;
                    int mostRecentOnStack = st.Pop().time;
                    countThisTask = tasks[i].time - mostRecentOnStack;
                    result.Add(countThisTask - countTimeSoFar + 1);
                    countTimeSoFar = countTimeSoFar + countThisTask + 1;
                }
            }

            result.Reverse();
            return result.ToArray();
        }
    }
    public class function
    {
        public int FunctionID;
        public string status;
        public int time;
        public function(int id, string s, int t)
        {
            FunctionID = id;
            status = s;
            time = t;
        }
    }
}
