// See https://aka.ms/new-console-template for more information
int[,] Csharp= new int[3,3]{{1,0,2},{0,0,0},{3,0,4}};
int x= Convert.ToInt32(Console.ReadLine());
int y= Convert.ToInt32(Console.ReadLine());
int[,] loc= new int[,]{{x},{y}};
Console.WriteLine(loc[0,0].ToString());
int num2= loc[0,0];
for (int xloc=0; xloc < 3  ; xloc++  )
{   
    int num =0;
    for (int yloc=0; yloc <3 ;yloc++ )
    {
       num= Csharp[xloc,yloc];
       if( num == num2)
       Console.WriteLine(Csharp[xloc,yloc].ToString());
    }
}
