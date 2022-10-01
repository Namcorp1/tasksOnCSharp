// 19. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = true;
bool y = true;

Console.WriteLine($"x={x}, y={y}");
Console.WriteLine(!( x || y));
Console.WriteLine(!x && !y);

if(!( x || y) == !x && !y)
{
    Console.WriteLine("Высказывание истинно!");
}
else
{
    Console.WriteLine("Высказывание ложно!");
}