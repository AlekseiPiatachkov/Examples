// Distans 10000, FirstFriendSpeed 2, SecondFriendSpeed 3, DogSpeed 5
// V = S/T, T = S/V, S = T*V


int a = 2, b = 5, c = 3; // m/s
int Distans = 10000;
int currentS = 0; // Distans 
int x = 0; // FirstFriend
int y = 0; // time

int count = 0;

while(Distans > 10)
{
    if(x == 0)
    {
        y = Distans/(c + a);
        currentS = y * (a + b);
        x = 1;
        Distans = currentS - (y * (a + b));
    }
    else
    {
        y = Distans/(c + b);
        currentS = y * (a + b);
        x = 0;
        Distans = currentS - (y * (a + b));
    }
        
    count++;
}
Console.WriteLine(count);
