using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    class TestTowerOfHanoi
    {

        public static void Main()
        {
            int size = 3;
            Stack<string>[] towers = new Stack<string>[3]
            {
                new Stack<string>(size),
                new Stack<string>(size),
                new Stack<string>(size)
            };
            TowerOfHannoi towerOfHanoi = new TowerOfHannoi();
            towerOfHanoi.Move(towers);
        }
    }
}
