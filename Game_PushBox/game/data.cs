using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class data
    {

        internal static int x = 0;
        internal static int y = 0;//人的位置
        internal static int move_x = 0;
        internal static int move_y = 0;//人的移动
        internal const int WIDTH = 13;
        internal const int HEIGHT = 12;
        internal static int[,] map = new int[HEIGHT, WIDTH]{
                           {0,0,0,0,0,1,1,1,1,1,1,1,0},
                {0,0,0,0,0,1,0,0,1,0,0,1,0},
                {0,0,0,0,0,1,0,0,2,2,0,1,0},
                {1,1,1,1,1,1,0,2,1,0,0,1,0},
                {1,4,4,4,1,1,1,0,1,0,0,1,1},
                {1,4,0,0,1,0,0,2,0,1,0,0,1},
                {1,4,0,0,0,0,2,0,2,0,2,0,1},
                {1,4,0,0,1,0,0,2,0,1,0,0,1},
                {1,4,4,4,1,1,1,0,1,0,0,1,1},
                {1,1,1,1,1,1,0,2,0,0,0,1,0},
                {0,0,0,0,0,1,0,3,1,0,0,1,0},
                {0,0,0,0,0,1,1,1,1,1,1,1,0}
                        };
        internal static int[,] map0 = new int[HEIGHT, WIDTH]{
                {0,0,0,0,0,1,1,1,1,1,1,1,0},
                {0,0,0,0,0,1,0,0,1,0,0,1,0},
                {0,0,0,0,0,1,0,0,2,2,0,1,0},
                {1,1,1,1,1,1,0,2,1,0,0,1,0},
                {1,4,4,4,1,1,1,0,1,0,0,1,1},
                {1,4,0,0,1,0,0,2,0,1,0,0,1},
                {1,4,0,0,0,0,2,0,2,0,2,0,1},
                {1,4,0,0,1,0,0,2,0,1,0,0,1},
                {1,4,4,4,1,1,1,0,1,0,0,1,1},
                {1,1,1,1,1,1,0,2,0,0,0,1,0},
                {0,0,0,0,0,1,0,3,1,0,0,1,0},
                {0,0,0,0,0,1,1,1,1,1,1,1,0}
                        };//地图信息
        internal static bool time_key = true;//时间显示开关
        internal static int shape = 0;//人物形状
        internal static int box = 0;//箱子数量
        internal static bool flag = true;//游戏是否结束
        internal static void clear_move()
        {
            move_x = 0;
            move_y = 0;
        }
        internal static void init()
        {
            for (int i = 0; i < HEIGHT  ; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
      
                    if (map[i, j] == 3)
                    {
                        x = j;
                        y = i;
                    }

                    if (map[i, j] == 2)
                    {
                        box++;
                    }
                }
            }
        }
    }
}
