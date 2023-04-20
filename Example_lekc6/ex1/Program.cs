string text = "(2,3) (3,5) (3,9)".Replace("(", "").Replace(")", "");
var data = text.Split(" ").ToArray();

for (int i = 0; i < data.Length; i++)
{
      Console.Write(data[i]+ " ");
}