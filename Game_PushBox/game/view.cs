using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class view:data
    {
    public  static void display()
        {
           Console.Clear();
            //打印新地图
            int cnt = 0;
            for (int i = 0; i < HEIGHT; i++)
                    {
                        for (int j = 0; j < WIDTH; j++)
                        {
                            if (map[i, j] == 0)
                            {
                                Console.Write("　");
                            }
                            if (map[i, j] == 1)
                            {
                        cnt++;
                                Console.Write("■");
                            }
                            if (map[i, j] == 2)
                            {
                                Console.Write("□");
                            }
                            if (map[i, j] == 3)
                            {
                                if(shape==0)
                                Console.Write("♀");
                                else if(shape==1)
                                    Console.Write("㊚");
                                else if (shape == 2)
                                    Console.Write("囍");
                                else if(shape==3)
                                    Console.Write("卐");
                            }
                            if (map[i, j] == 4)
                            {
                                Console.Write("☆");
                            }
                            if (map[i, j] == 5)
                            {
                                Console.Write("★");
                            }
                        }
                        Console.WriteLine();
                    }
            if (cnt == box)
            {
                Console.WriteLine("Good Game!!!");
                flag = false;
            }
                }
           
        public   static    void display_time()
                {

                }
            }
}
