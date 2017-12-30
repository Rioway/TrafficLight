using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace LightClassLibrary1
{
    public class TrafficLight
    {
        //属性和字段
        private bool[,] light01 = new bool[20, 10];
        private bool[,] light02 = new bool[20, 10];

        public bool[,] Light01
        {
            get { return light01; }
            set { light01 = value; }
        }
        public bool[,] Light02
        {
            get { return light02; }
            set { light01 = value; }
        }

        //方法

        //构造方法
        public TrafficLight() { }
        public TrafficLight(int number)
        {
            string strNumber = number.ToString("00");

            bool[,] light = new bool[20, 10];
            char charNumber;

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    light = light01;
                    charNumber = char.Parse(strNumber.Substring(0, 1));
                }

                else
                {
                    light = light02;
                    charNumber = char.Parse(strNumber.Substring(1, 1));
                }

                    switch (charNumber)
                {
                    case '0':
                        for(int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (row < 2) light[row, col] = true;
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;
                                else if (col < 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2) light[row, col] = true;
                                else light[row, col] = false;
                            }
                        }
                        break;
                    case '1':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (col >= light.GetLength(1) - 2) light[row, col] = true;
                                else light[row, col] = false;
                            }
                        }
                        break;
                    case '2':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (row < 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                //c: (col >= light.GetLength(1) - 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;
                                else if (col < 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                //  f: (col < 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;
                                    else light[row, col] = false;
                            }
                        }
                        break;
                    case '3':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (row < 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;
                                //  e: (col < 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                //  f: (col < 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;
                                else light[row, col] = false;
                            }
                        }
                        break;
                    case '4':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                              //  a: (row < 2) light[row, col] = true;
                                if (col >= light.GetLength(1) - 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                //  d: (row >= light.GetLength(0) - 2) light[row, col] = true;
                                //  e: (col < 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col < 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;
                                else light[row, col] = false;
                            }
                        }
                        break;
                    case '5':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (row < 2) light[row, col] = true;
                                // b: (col >= light.GetLength(1) - 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;
                                // e: (col < 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col < 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;
                                else light[row, col] = false;
                            }
                        }
                        break;
                    case '6':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (row < 2) light[row, col] = true;
                               // b: (col >= light.GetLength(1) - 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;
                                else if (col < 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col < 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;
                                else light[row, col] = false;
                            }
                        }
                        break;
                    case '7':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (row < 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                        // d: (row >= light.GetLength(0)-2) light[row, col] = true;
                        // e: (col < 2 && row >= light.GetLength(0)/2) light[row, col] = true;
                        // f: (col < 2 && row <= light.GetLength(0)/2) light[row, col] = true;
                        // g: (row == light.GetLength(0)/2 || row == light.GetLength(0)/2 - 1) light[row, col] = true;
                                else light[row, col] = false;
                            }
                        }
                        break;
                    case '8':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (row < 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;
                                else if (col < 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col < 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;
                                else light[row, col] = false;
                            } 
                        }
                        break;
                    case '9':
                        for (int row = 0; row < light.GetLength(0); row++)
                        {
                            for (int col = 0; col < light.GetLength(1); col++)
                            {
                                if (row < 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col >= light.GetLength(1) - 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row >= light.GetLength(0) - 2) light[row, col] = true;
                                // e: (col < 2 && row >= light.GetLength(0) / 2) light[row, col] = true;
                                else if (col < 2 && row <= light.GetLength(0) / 2) light[row, col] = true;
                                else if (row == light.GetLength(0) / 2 || row == light.GetLength(0) / 2 - 1) light[row, col] = true;
                                else light[row, col] = false;
                            }
                        }
                        break;
                    default:
                        break;
                        //                                                                                                               a                          
                        // a: (row < 2) light[row, col] = true;                                                                    ==========      
                        // b: (col >= light.GetLength(1)-2 && row <= light.GetLength(0)/2) light[row, col] = true;             =        =
                        // c: (col >= light.GetLength(1)-2 && row >= light.GetLength(0)/2) light[row, col] = true;          f  =   g    =   b
                        // d: (row >= light.GetLength(0)-2) light[row, col] = true;                                              ==========
                        // e: (col < 2 && row >= light.GetLength(0)/2) light[row, col] = true;                                   =        =
                        // f: (col < 2 && row <= light.GetLength(0)/2) light[row, col] = true;                                e  =        =   c
                        // g: (row == light.GetLength(0)/2 || row == light.GetLength(0)/2 - 1) light[row, col] = true;         ==========
                        //                                                                                                                d
                }

            }
        }

        //打印方法
        public void PrintNumber(string color)
        {
            for (int row = 0; row < light01.GetLength(0); row++)
            {
                for (int col01 = 0; col01 < light01.GetLength(1); col01++)
                {
                    if ( light01[row, col01]== true)
                    {
                        PrintCustom.PrintUseColor(color, "●");
                    }
                    else
                    {
                        PrintCustom.PrintUseColor("white", "●");
                    }
                }
                Console.Write("\t");
                for (int col02 = 0; col02 < light02.GetLength(1); col02++)
                {
                    if (light02[row, col02] == true)
                    {
                        PrintCustom.PrintUseColor(color, "●");
                    }
                    else
                    {
                        PrintCustom.PrintUseColor("white", "●");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            PrintCustom.PrintUseColor("cyan", "【暂停/启动: 点击Space    重新设定时间：点击Enter    结束：点击End】");
        }

        //等待响应
        public static int Wait()
        {
            int flag = 1;
            int tiems = 0;
            while (true)
            {
                tiems++;
                System.Threading.Thread.Sleep(50);

                //检测键盘的响应
                while(Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    switch (info.Key)
                    {
                        case ConsoleKey.Spacebar:
                            if (flag == 1) flag = 2;
                            else if (flag == 2) flag = 3;
                            break;
                        case ConsoleKey.Enter:
                            flag = 4;
                            break;
                        case ConsoleKey.End:
                            flag = 5;
                            break;
                        default:
                            break;
                    }
                }
                switch (flag)
                {
                    case 1:  //继续
                        if(tiems==20) return 1;
                        break;
                    case 2:  //暂停
                        tiems = 0;
                        break;
                    case 3:  //暂停后继续
                        return 1;
                    case 4:  //重新设定时间
                        return 2;
                    case 5:  //退出
                        return 3;

                    default:
                        break;
                }
            }
            return 1;
        }
    }
}
