// Distans 10000, FirstFriendSpeed 2, SecondFriendSpeed 3, DogSpeed 5
// V = S/T, T = S/V, S = T*V


int a = 2, b = 3, c = 5; // m/s
int Distans = 10000;
int currentS = 0; // Distans 
int y = 0; // time
int friend = 2;

int count = 0;

while(Distans > 10)
{
    if(friend == 1)
    {
        y = Distans/(c + a);
        currentS = y * (a + b);
        friend = 2;
        Distans = currentS - (y * (a + b));
    }
    else
    {
        y = Distans/(c + b);
        currentS = y * (a + b);
        friend = 1;
        Distans = currentS - (y * (a + b));
    }
        
    count++;
}
Console.WriteLine(count);
