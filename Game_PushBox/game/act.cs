using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class act:data
    {
        
        //StringBuilder
    
        static public void move()
        {
            ConsoleKeyInfo aj = Console.ReadKey();
            data.clear_move();
            switch (aj.Key.ToString())
            {
                case "UpArrow": y--; move_y--; break;
                case "DownArrow": y++; move_y++; break;
                case "LeftArrow": x--; move_x--; break;
                case "RightArrow": x++; move_x++; break;
                case "Spacebar": change(); return; 
                default: break;
            }
           // if(map[y, x] == 1||(map[y, x] == 2 || map[y, x] == 5)&&(map[y + move_y, x + move_x] == 1 || map[y + move_y, x + move_x] == 2 || map[y + move_y, x + move_x] == 5))
            if (map[y, x] == 0 || map[y, x] == 4)//小人的下一个坐标为空地，进行移动
            {
                map[y, x] = 3;
                if (map0[y-move_y, x-move_x] == 4)//如果小人现在的坐标是目标点的坐标
                {
                    map[y - move_y, x - move_x] = 4;
                }
                else//如果小人现在的坐标不是目标点的坐标
                {
                    map[y - move_y, x - move_x] = 0;
                }
            }

            else if (map[y, x ] == 1)//小人的下一个坐标为墙
            {
                y -= move_y;
                x -= move_x;
                return; }

            else if (map[y, x] == 2 || map[y, x] == 5)//小人的下一个坐标为未到达目标的箱子或到达目标的箱子
            {
                if (map[y+move_y, x+move_x] == 1 || map[y+move_y, x+move_x] == 2 || map[y+move_y, x+move_x] == 5)//箱子的下一个目标为墙或空箱子或到达目标的箱子
                {
                    y -= move_y;
                    x -= move_x; 
                    return; }
                else if (map[y+move_y, x +move_x] == 0)//箱子的下一个目标为空地
                {
                    map[y + move_y, x + move_x] = 2;
                    map[y, x] = 3;
                    if (map0[y-move_y, x-move_x] == 4)//如果小人现在的坐标是目标点的坐标
                    {
                        map[y-move_y, x-move_x] = 4;
                    }
                    else//如果小人现在的坐标不是目标点的坐标
                    {
                        map[y - move_y, x - move_x] = 0;
                    }
                }
                else if (map[y + move_y, x + move_x] == 4)//箱子的下一个目标为目标点
                {
                    map[y + move_y, x + move_x] = 5;
                    map[y, x] = 3;
                    if (map0[y - move_y, x - move_x] == 4)//如果小人现在的坐标是目标点的坐标
                    {
                        map[y - move_y, x - move_x] = 4;
                    }
                    else//如果小人现在的坐标不是目标点的坐标
                    {
                        map[y - move_y, x - move_x] = 0;
                    }
                }
            }
        }
        static void change()
        {
            shape = (shape + 1) % 4;
        }
    }
}
