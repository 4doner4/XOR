
using System.Text;

string str = Console.ReadLine();
int x = Convert.ToInt32(Console.ReadLine());

string numb = Convert.ToString(x, 2);
char[] arrnumb = numb.ToCharArray();
Console.WriteLine("numb bytes");
for (int i = 0; i < arrnumb.Length; i++)
{
    Console.Write($" {(Convert.ToInt32(arrnumb[i]) - 48)} ");

}

StringBuilder sb = new StringBuilder();
foreach (byte b in System.Text.Encoding.Unicode.GetBytes(str))
    sb.Append(Convert.ToString(b, 2));

string a = Convert.ToString(sb);
int j = 0;
char[] arr = a.ToCharArray();
char[] result = new char[arr.Length];
Console.WriteLine("\n string bytes");
for (int i = 0; i < arr.Length; i++)
{

    Console.Write($"{(Convert.ToInt32(arr[i]) - 48)} ");
 
}
Console.WriteLine("\n result");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{(Convert.ToInt32(arr[i]) - 48) ^ (Convert.ToInt32(arrnumb[j]) - 48)}");
    result[i] = Convert.ToChar(((Convert.ToInt32(arr[i]) - 48) ^ (Convert.ToInt32(arrnumb[j]) - 48))+48);
    if (j == arrnumb.Length - 1)
    {
        j = 0;
    }
    j++;
}
String data = new String(result);


Console.WriteLine($"\n{BinaryToString(data)}");


static string BinaryToString(string data)
{
    List<Byte> byteList = new List<Byte>();

    for (int i = 0; i < data.Length; i += 8)
    {
        byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
    }

    return Encoding.ASCII.GetString(byteList.ToArray());
}
