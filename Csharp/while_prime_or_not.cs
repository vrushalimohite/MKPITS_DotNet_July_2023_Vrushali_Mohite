using System;
namespace program
{
    class prime
    {
        static void Main()
        {
            int no;
            Console.WriteLine("Enter number");
            no = Convert.ToInt32(Console.ReadLine());
            int cnt = 2;
            int flag = 0;
            while(cnt<no)
            {
                if(no%cnt==0)
                {
                    flag = 1;
                    break;
                }
                cnt++;
            }
            if (flag == 0)
            {
                Console.WriteLine("Prime no");
            }
            else
            {

                Console.WriteLine("  it is Not Prime no");
            }


        }
    }
}