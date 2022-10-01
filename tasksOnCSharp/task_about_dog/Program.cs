/* Два друга движутся навстречу с заданной скоростью.
Скорость первого — 1 м/с, второго — 2 м/с.
У них есть собака, которая бегает со скоростью 5 м/с. 
Когда друзья начинают свой путь, собака бежит от одного друга к другому,
добегает, разворачивается и тут же бежит обратно.
Сколько раз собака перебежит от одного друга к другому, пока они не встретятся? */

int count = 0;
double distance = 10000;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
int friend = 2;
double time = 0;

while (distance > 5)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count += 1;
}
Console.WriteLine($"Собака пробежала {count} раз между друзьями.");