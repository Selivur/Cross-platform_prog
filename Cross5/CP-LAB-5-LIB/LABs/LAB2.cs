using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_LAB_5_LIB.LABs
{
    public class LAB2 : ILabWorker
    {
        public async Task<string> GetOutputForLab(string Input)
        {
            return await Task.Run(() =>
            {
                return GetOutput(Input);
            });
        }

        private string GetOutput(string Input)
        {
            var lines = Input.Split("\r\n");
            int[] arr = { 0 };
            try
            {
                int count = int.Parse(lines[0]);
                arr = new int[count];
                string[] stringArr = lines[1].Split(' ');
                if (count < 0 || count > 100)
                    throw new Exception("Invalid input values");
                if (count != stringArr.Length)
                    throw new Exception("Invalid massive length");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(stringArr[i]);
                    if (arr[i] > 1000 || arr[i] < 1)
                        throw new Exception("Invalid input values in masive");
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
            int firstPlayer = 0;
            int secondPlayer = 0;

            while (arr.Length > 0)
            {
                if (arr[0] > arr[arr.Length - 1])
                {
                    firstPlayer += arr[0];
                    arr = arr.Where((source, index) => index != 0).ToArray();
                }
                else
                {
                    firstPlayer += arr[arr.Length - 1];
                    arr = arr.Where((source, index) => index != arr.Length - 1).ToArray();
                }
                if (arr.Length == 0)
                    break;
                if (arr[0] > arr[arr.Length - 1])
                {
                    secondPlayer += arr[0];
                    arr = arr.Where((source, index) => index != 0).ToArray();
                }
                else
                {
                    secondPlayer += arr[arr.Length - 1];
                    arr = arr.Where((source, index) => index != arr.Length - 1).ToArray();
                }
            }
            if (firstPlayer == secondPlayer)
                return "0";
            else if (firstPlayer > secondPlayer)
                return "1";
            else
                return "2";
        }
    }
}
