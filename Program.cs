using System;
using System.Linq;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<char> a = new List<char>();
string input = "(((({})))";

Console.WriteLine("Please Type input and Press Enter:");
input = Console.ReadLine();

Dictionary<char, char> Dic = new Dictionary<char, char>
{
    {'(', ')'},
    {'[', ']'},
    {'{', '}'}
};

var output = true;
var valid = true;

foreach (var item in input)
{
    if (!Dic.ContainsKey(item) && !Dic.ContainsValue(item))
    {
        valid = false;
        break;
    }
    if (Dic.ContainsKey(item))
    {
        a.Add(item);
    }
    else if (Dic.ContainsValue(item))
    {
        if (a.Last() != Dic.FirstOrDefault(x => x.Value == item).Key)
        {
            output = false;
            break;
        }
        else
            a.RemoveAt(a.Count - 1);
    }
}

if (valid)
    Console.WriteLine(output);
else
    Console.WriteLine("invalid input");
Console.ReadKey();



