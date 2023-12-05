﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Arrays
{
    /// <summary>
    /// Company name: KLA
    /// Level: Medium
    /// TODO:: Find smallest missing number that cannot be 
    /// achieved by doing bitwise OR of all elements in any of its subset
    /// </summary>
    public class SmallestMissingNumber
    {
        public int FindSmallestMissingNumber(int[] arr)
        {

            int ExpectedNumber = 1;
            arr = new int[] { 1, 2, 3, 4 };//8
            arr = new int[] { 1, 2, 8 };//4
            arr = new int[] { 1, 2, 5, 6 };//4
            arr = new int[] { 1, 2, 7 };//8
            arr = new int[] { 1, 3 };//2
            arr = new int[] { 5 };//1
            arr = new int[] { 1, 4 };//2
            //5 op:1
            //1,2,3,4 op:8
            //1,2,3 op:4
            //1,2,4 op:8
            //1,4 op: 2
            //1,2,4,6 op:8
            //1,2,7 op:8
            //1,2,8 op:4
            //1,2,5,6 op:4
            int BitwiseORVal = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ExpectedNumber)
                {
                    ExpectedNumber++;
                }
                else
                {
                    if ((arr[i] - BitwiseORVal) > 1)
                    {
                        break;
                    }
                }
                BitwiseORVal |= arr[i];
            }
            ExpectedNumber = BitwiseORVal + 1;
            return ExpectedNumber;
        }
    }
}
