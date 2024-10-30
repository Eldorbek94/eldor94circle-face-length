

Console.WriteLine("Calculate circle face and length \n Radius di kiriting R:");
string rad = Console.ReadLine();
int radius = Convert.ToInt32(rad);
decimal pi = (decimal)Math.PI;

//calculate Circle's face
decimal S= pi*radius*radius;
//calculate Circle's Length
decimal L = 2*pi*radius;

Console.WriteLine($"This is S:{S}");
Console.WriteLine($"This is L:{L}");
