using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            data.init();
            while (data.flag)
            {
                view.display();
                act.move();
               
            }
        }
    }
}
