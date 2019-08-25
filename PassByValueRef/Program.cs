using System;
using System.Text;

namespace PassByValueRef
{
  class Program
  {
    static void Main(string[] args)
    {
      string m = "A", n = "B";
      Swap(m, n);
      Console.WriteLine($"M = {m}, N = {n}");

      StringBuilder sb1 = new StringBuilder("A");
      StringBuilder sb2 = new StringBuilder("B");
      Swap(sb1, sb2);
      Console.WriteLine($"{sb1.ToString()} {sb2.ToString()}");

      StringBuilder buildText = new StringBuilder();
      AddSomeText(buildText);
      Console.WriteLine(buildText.ToString());

      string myText = "Hello";
      ModifyText(myText);
      Console.WriteLine(myText);
    }

    private static void ModifyText(string myText)
    {
      myText = myText + " morining";
    }

    private static void AddSomeText(StringBuilder buildText)
    {
      buildText.Append("Hello ");
      buildText = null;
    }

    private static void Swap(StringBuilder sb1, StringBuilder sb2)
    {
      StringBuilder t = sb1;
      sb1 = sb2;
      sb2 = t;
    }

    private static void Swap(string m, string n)
    {
      string t = m;
      m = n;
      n = t;
    }
  }
}
