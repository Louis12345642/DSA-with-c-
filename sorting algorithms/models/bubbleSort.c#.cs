namespace models
{
    /*
    bubbleSort() : this is a method that performs a bubble sort on an array


    */
    public class bubbleSort
    {


        public static void swap(int i, int j)
        {
            (j, i) = (i, j);
        }

        //trying to return an array as part of method return

        public static int[] arrReturn()
        {

            int[] arr= {12,4,5,5};
            return arr;
        }

        public static void BubbleSort(int[] arr)
        {

            //loop through as the parse

            for (int i = 0; i < arr.Length; i++)
            {

                //make the second loop for comparison
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] > arr[j])
                    {
                        swap(arr[i], arr[j]);
                    }

                }
            }

            Console.WriteLine("The sorted array in ascending order:  ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }



        }

    }
}
