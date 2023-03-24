// Distans 10000, FirstFriendSpeed 2, SecondFriendSpeed 3, DogSpeed 5
// V = S/T, T = S/V, S = T*V


int a = 2, b = 3, c = 2; // m/s
int Distans = 10000;
int currentS = 0; // CurrentDistans
int x = 0; // FirstFriend
int y = 0; // time

int count = 0;

while(Distans > 10)
{
    if(x == 0)
    {
        y = Distans/(c + a);
        x = 1;
    }

    if(x == 1)
    {
        y = Distans/(c + b);
        x = 0;

    }
    currentS = Distans - y;
    Distans = currentS;
    count++;
}
Console.WriteLine(count);
