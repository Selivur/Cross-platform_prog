int[] arr= { 0 };
try
{
    string[] lines = System.IO.File.ReadAllLines
        ("INPUT.txt");
    int count = int.Parse(lines[0]);
    arr = new int[count];
    string[] stringArr = lines[1].Split(' ');
    if (count < 0 || count > 100)
        throw new Exception("Invalid input values");
    if (count != stringArr.Length)
        throw new Exception("Invalid massive length");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(stringArr[i]);
        if (arr[i] > 1000 || arr[i] < 1)
            throw new Exception("Invalid input values in masive");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
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
    File.WriteAllText("OUTPUT.txt", "0");
else if (firstPlayer > secondPlayer)
    File.WriteAllText("OUTPUT.txt", "1");
else
    File.WriteAllText("OUTPUT.txt", "2");