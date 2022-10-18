Console.Clear();
int xa = 30, ya = 1,
    xb = 1, yb = 15,
    xc = 60, yc = 15;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while (count<10000)
{
  int points = new Random().Next(0, 3);
    if ( points == 0)
  {
    x = (x+xa)/2;
    y = (y+ya)/2;
  }
    if ( points == 1)
  {
    x = (x+xb)/2;
    y = (y+yb)/2;
  }
    if ( points == 2)
  {
    x = (x+xc)/2;
    y = (y+yc)/2;
  }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count +=1;
}