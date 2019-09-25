using System;
using System.Text;


    public static class Byndyusoft
    {

    public static int GetSumOfMins(ref int[] arr)
    {
                if (arr == null)
                {   
                throw new ArgumentException("Input Array is null");
                }

        //catch (Exception ex)
        // {
        //    throw;
        // }


        if (arr.Length == 1)//if arr.Length==1 then let arr[0]=max && arr[0]==min
            {
                return checked(arr[0] + arr[0]);
            }


            int firstMinimumPos, secondMinimumPos;
            int c = 0;//third el-t for swap)) 
            if (arr[0] < arr[1])
            {
                firstMinimumPos = 0;
                secondMinimumPos = 1;
            }
            else
            {
                firstMinimumPos = 1;
                secondMinimumPos = 0;
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] < arr[firstMinimumPos])
                {
                    c = firstMinimumPos;
                    firstMinimumPos = i;
                    if (arr[c] < arr[secondMinimumPos])
                    {
                        secondMinimumPos = c;
                    }
                }
                else
                {
                    if (arr[i] < arr[secondMinimumPos]) secondMinimumPos = i;
                }
            }
            return checked(arr[firstMinimumPos] + arr[secondMinimumPos]);
        }
}

