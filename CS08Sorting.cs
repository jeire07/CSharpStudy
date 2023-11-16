using System.Runtime.InteropServices;
using static System.Console;

namespace CSharpStudy
{
    public class CS08Sorting
    {
        public void UseAllSorting()
        {
            WriteLine();

            // init arr for sort
            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };
            PrintIntArray(arr);

            // sort items in arr array with Selection Sort method
            SelectionSort(arr);

            // print all items
            PrintIntArray(arr);
            WriteLine();

            // re-init arr for sort
            arr = new int[] { 5, 2, 4, 6, 1, 3 };
            PrintIntArray(arr);

            // sort items in arr array with Insertion Sort method
            InsertionSort(arr);

            // print all items
            PrintIntArray(arr);
            WriteLine();

            //re-init arr for sort
            arr = new int[] { 10, 7, 9, 11, 2, 4, 8, 5, 1, 3, 6 };
            PrintIntArray(arr);

            // sort items in arr array with Quick Sort method
            QuickSort(arr, 0, arr.Length - 1);

            // print all items
            PrintIntArray(arr);
            WriteLine("------------------");

            //re-init arr for sort
            arr = new int[] { 7, 5, 2, 8, 4, 6, 1, 3 };
            PrintIntArray(arr);

            // sort items in arr array with Merge Sort method
            MergeSort(arr, 0, arr.Length - 1);

            // print all items
            PrintIntArray(arr);
            WriteLine();
        }

        /// <summary>
        /// sort array's items by
        /// selecting smallest item and moveand move it to the front.
        /// </summary>
        /// <param name="arr">unsorted integer array</param>
        private void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;

                // find which item is minimum
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
                PrintIntArray(arr);
            }
        }

        /// <summary>
        /// sort array's items by
        /// After sorting the front array,
        /// insert next item at the appropriate position
        /// </summary>
        /// <param name="arr">unsorted integer array</param>
        private void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int key = arr[i];

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
                PrintIntArray(arr);
            }
        }

        /// <summary>
        /// sort array's items by
        /// separating the larger and smaller elements
        /// based on the pivot
        /// </summary>
        /// <param name="arr">unsorted integer array</param>
        /// <param name="left">minimum array index</param>
        /// <param name="right">maximum array index</param>
        private void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }

        /// <summary>
        /// recursively dividing the unsorted list into n sublists
        /// 
        /// </summary>
        /// <param name="arr">unsorted integer array</param>
        /// <param name="left">minimum array index</param>
        /// <param name="right">maximum array index</param>
        /// <returns></returns>
        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                    PrintIntArray(arr);
                }
            }

            Swap(arr, i + 1, right);

            PrintIntArray(arr);
            WriteLine();

            return i + 1;
        }

        /// <summary>
        /// Swap two items with each other
        /// </summary>
        /// <param name="arr">array that have two items</param>
        /// <param name="i">item1's index</param>
        /// <param name="j">item2's index</param>
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// sort array's items by ascending order
        /// </summary>
        /// <param name="arr">integer array</param>
        private void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[arr.Length];

            int i = left;
            int j = mid + 1;
            int k = left;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            for (int l = left; l <= right; l++)
            {
                arr[l] = temp[l];
            }
            PrintIntArray(temp);
            PrintIntArray(arr);
            WriteLine();
        }

        public void PrintIntArray(int[] arr)
        {
            int MaxIndex = arr.Length;
            for(int i = 0; i < arr.Length; i++)
            {
                if (i < (arr.Length - 1))
                {
                    Write($" {arr[i]}, ");
                }
                else
                {
                    WriteLine($" {arr[i]}");
                }
            }
        }
    }
}