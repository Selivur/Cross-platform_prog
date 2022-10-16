string[] lines = System.IO.File.ReadAllLines
        (@"C:\Users\si010\source\repos\Cross2\INPUT.txt");
int count = int.Parse(lines[0]);
int[] arr = new int[count];
string[] stringArr = lines[1].Split(' ');
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(stringArr[i]);
}    
int firstPlayer=0;
int secondPlayer=0;

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
    File.WriteAllText(@"C:\Users\si010\source\repos\Cross2\OUTPUT.txt", "0");
else if (firstPlayer > secondPlayer)
    File.WriteAllText(@"C:\Users\si010\source\repos\Cross2\OUTPUT.txt", "1");
else
    File.WriteAllText(@"C:\Users\si010\source\repos\Cross2\OUTPUT.txt", "2");