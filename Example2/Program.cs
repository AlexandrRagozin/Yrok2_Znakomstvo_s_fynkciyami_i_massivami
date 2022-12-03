int[] array = { 175, 24, 34, 466, 34, 63, 34, 91 };

int n = array.Length;
int find = 34;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}