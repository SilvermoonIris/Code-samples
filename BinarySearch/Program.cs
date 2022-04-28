using System;

class BinarySearch 
{
    public static void Main() 
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int searchTarget = 3;
        int result = BinSearch(arr, searchTarget);

        switch (result) 
        {
            case -1:
                {
                    Console.WriteLine("The number: \""+ searchTarget + "\" is not present in this array.");
                    break;
                }
            case -2:
                {
                    Console.WriteLine("Error: The lower range is larger than the uppper range\n Verify implementation");
                    break;
                }
            default:
                {
                    Console.WriteLine("The number: \""+ searchTarget +"\" was found at index: "+result+ ".");
                    break;
                }
                
        };
    }

    /// <summary>
    /// due to the nature of binary searches, the array MUST be sorted prior to search.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    static int BinSearch(int[] arr, int target) 
    {
        int left = 0; //index zero is always the leftmost element of an array
        int right = arr.Length-1; //the max index is always the rightmost element of an array

        //effectively an infinite loop that checks that the range specified is a valid one
        ////(i.e. not from N to n, where N > n)
        while (left <= right)
        {
            //find the middle index
            //(will default to the lower value if the length is even due to integer division)
            int middle = left + (right-left)/2; 

            //Check if the target is in the middle index
            if (arr[middle] == target) 
            {
                return middle;
            }

            //if the target value is greater than the one in the middle index,
            //ignore the left half of the array
            if (arr[middle] < target)
            {
                left = middle+1;
            }
            else 
            {
                //if the target value is smaller than the one in the middle index,
                //ignore the right half of the array
                right = middle-1;
            }

            //if the function reaches this point, it means that the desired value,
            //is not present in the array.
            return -1;
        }
        //error case bad implementation
        return -2;
    }
}