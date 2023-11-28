using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.CherepanovAE.ConsoleApp.Lab7.V2.Lib
{
    public class DataService
    {
        public int CountNegativeNumInArray(int[] intArray)
        {
            int count = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < 0)
                {
                    count++;
                }
            }
            return count;
        }
        public int CountPositiveNumInArray(int[] intArray)
        {
            int count = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountChetNumInArray(int[] intArray)
        {
            int count = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountNeChetNumInArray(int[] intArray)
        {
            int count = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public Boolean CountNumInArray(int[] intArray, int num)
        {
            Boolean flag = false;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == num)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public float CountMiddleNumInArray(int[] intArray)
        {
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            float result = sum / intArray.Length;

            return result;
        }

        public int CountMinNumInArray(int[] intArray)
        {
            int minNum = intArray[0];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (minNum > intArray[i])
                {
                    minNum = intArray[i];
                }
            }

            return minNum;
        }
    }
}