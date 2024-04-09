namespace models{

     class selectionSort{

        //creating a selection sort method

        public static void SelectionSort(int[] arr){
            //loop through the array to get the parses in the algorithm
            for(int i=0;i<arr.Length;i++){
                int min =i;
                //create the second loop to check for the minimum number in the array

                for(int j =i+1;j<arr.Length;j++){
                    //check for the minimum number in the array
                    if(arr[j]<arr[min]){
                        min =j;
                    }
                    //check if the arr[i] is not equal to the minimum

                    if(arr[i]!=arr[min]){
                        (arr[min], arr[i]) = (arr[i], arr[min]);
                    }
                }

            }

            //displaying the result on the console

            Console.WriteLine("selection sort result is :");
            for(int i =0;i<arr.Length;i++){
            
                Console.Write(arr[i]+" ");
            
            }

        }

}

}