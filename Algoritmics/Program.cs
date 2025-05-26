// See https://aka.ms/new-console-template for more information
using Algoritmics;
using System.Runtime.InteropServices;

Random random = new Random();
string letters = "qwertyuiopasdfghjklzxcvbnm";
Console.WriteLine("Start");
DFS dFS = new DFS(10);
for(int i =0; i < 10; i++)
{
    for(int j = 0; j < random.Next(0,10); j++)
    {
        int randomVertex = random.Next(0, 10);
        dFS.insert(i, randomVertex);
    }
}
dFS.print();

bool[] visisted = new bool[10]; 
dFS.search(1,visisted);



///////////



int[] initArr(int size, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = random.Next(0, max);
    return arr;
}
void printArr(int[] arr) 
{
    foreach (int item in arr)
        Console.Write($"{item} ");
    Console.WriteLine();
}
void sortBuble()
{
    int[] arr = initArr(30,30);
    printArr(arr);
    bool sorted = false;
    while (!sorted)
    {
        sorted = true;
        for(int i = 0; i < arr.Length-1; i++)
        { 
            if (arr[i] > arr[i+1]) 
            {
                int mid = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = mid;
                sorted = false;
            }
        }
    }
    printArr(arr);
}
void sortBubleWithoutValue()
{
    int[] arr = initArr(30, 30);
    printArr(arr);
    bool sorted = false;
    for(int iter = 0; iter < arr.Length && !sorted; iter++)
    {
        sorted = true;
        for(int i = 0; i < arr.Length - iter - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                int mid = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = mid;
                sorted = false;
            }
        }
    }
    printArr(arr);
}

void sortShake()
{
    int[] arr = initArr(30, 50);
    printArr(arr);
    bool sorted = false;
    int left = 0;
    int right = arr.Length - 1;
    for(int iter =0; iter < arr.Length && !sorted; iter++)
    {
        sorted = true;
        for(int i = left; i < right; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                int mid = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = mid;
                sorted = false;
            }
        }
        right--;
        for(int i = right; i > left; i--)
        {
            if (arr[i] < arr[i - 1])
            {
                int mid = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = mid;
                sorted = false;
            }
        }
        left++;

    }
    printArr(arr);
}
void sortComb()
{
    int[] arr = initArr(120,50);
    printArr(arr);
    
    double factor = 1.247;
    int step = (int)(arr.Length / factor);
    Console.WriteLine("step " + step);
    while(step >= 1)
    {
        for(int i = 0; (i + step) < arr.Length; i++)
        {
            if (arr[i] > arr[i + step])
            {
                int mid = arr[i];
                arr[i] = arr[i + step];
                arr[i + step] = mid;
            }
        }
        step = (int)(step / factor);
        
    }
    Console.WriteLine("after steps");
    printArr(arr);
    bool sorted = false;
    while (!sorted)
    {
        sorted = true;
        for(int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                int mid = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = mid;
                sorted = false;
            }
        }
    }
    Console.WriteLine("res");
    printArr(arr);

}
void sortAdd()
{
    int[] arr = initArr(20, 20);
    printArr(arr);
    for(int i = 0; i < arr.Length; i++)
    {
        int val = arr[i];
        int j = i;
        while(j > 0 && val < arr[j-1])
        {
            arr[j] = arr[j - 1];
            j--;
        }
        arr[j] = val;
    }
    printArr(arr);
}

void sortChoose()
{
    int[] arr = initArr(20, 20);
    printArr(arr);
    for(int i = 0; i < arr.Length; i++)
    {
        int min = arr[i];
        int id = i;
        for(int j = i+1; j < arr.Length; j++)
        {
            if (arr[j] < min)
            {
                min = arr[j];
                id = j;
            }
        }

        int mid = arr[i];
        arr[i] = arr[id];
        arr[id] = mid;

    }
    printArr(arr);
}
int partion(int[] arr, int low, int high)
{
    int pivot = arr[low];
    int left = low + 1;
    int right = high;
    while (true)
    {
        while (left <= right && arr[left] <= pivot)
            left++;
        while (right >= left && arr[right] >= pivot)
            right--;
        if (right < left)
            break;
        else
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
    int mid = arr[low];
    arr[low] = arr[right];
    arr[right] = mid;
    return right;
}
void sortRecursive(int[] arr, int low, int high)
{
    if(low < high)
    {
        int pivotInd = partion(arr,low,high);
        sortRecursive(arr, low, pivotInd - 1);
        sortRecursive(arr, pivotInd +1 , high);
    }
}
void sortFast()
{
    int[] arr = initArr(30, 30);
    printArr(arr);
    sortRecursive(arr,0,arr.Length-1);
    printArr(arr);
}
void merge(int[] arr, int low, int center, int high)
{
    int size1 = center - low + 1;
    int size2 = high - center;

    int[] left = new int[size1];
    int[] right = new int[size2];

    int i, j;

    for (i = 0; i < size1; i++)
        left[i] = arr[low + i];
    
    for (i = 0; i < size2; i++)
        right[i] = arr[center + i + 1];

    i = 0;
    j = 0;

    int k = low;

    while(i < size1 && j < size2)
    {
        if (left[i] < right[j])
        {
            arr[k] = left[i];
            i++;
        }
        else
        {
            arr[k] = right[j];
            j++;
        }
        k++;
    }
    for (; i < size1; i++, k++)
        arr[k] = left[i];
    for (; j < size2; j++, k++)
        arr[k] = right[j];

}
void divideArr(int[] arr, int low, int high)
{
    if(low < high)
    {
        int center = (low + high) / 2;
        divideArr(arr, low, center);
        divideArr(arr, center + 1, high);
        merge(arr, low, center, high);
    }
}
void sortMerge()
{
    int[] arr = initArr(30, 30);
    printArr(arr);
    divideArr(arr,0,arr.Length-1);
    printArr(arr);
}