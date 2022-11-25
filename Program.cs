// See https://aka.ms/new-console-template for more information

using findLCA;

LCA calcLCA1 = new LCA(11, 13);
LCA calcLCA2 = new LCA(13, 15);
LCA calcLCA3 = new LCA(10, 11);

Console.WriteLine("The LCA Test 1 is = " + calcLCA1.RunLCA().ToString());
Console.WriteLine("The LCA Test 2 is = " + calcLCA2.RunLCA().ToString());
Console.WriteLine("The LCA Test 3 is = " + calcLCA3.RunLCA().ToString());
