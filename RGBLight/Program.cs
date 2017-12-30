using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightClassLibrary1;
using Common;

namespace RGBLight
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入时间
            ReInput:
            Console.Clear();

            int greenTime, yellowTime, redTime;
            while(true)
            {
                PrintCustom.PrintUseColor("green", "请输入绿灯的时间： ");
                string str = Console.ReadLine();
                if(CheckInput(str))
                {
                    greenTime = Convert.ToInt32(str);
                    break;
                }
            }
            while (true)
            {
                PrintCustom.PrintUseColor("yellow", "请输入绿灯的时间： ");
                string str = Console.ReadLine();
                if (CheckInput(str))
                {
                    yellowTime = Convert.ToInt32(str);
                    break;
                }
            }
            while (true)
            {
                PrintCustom.PrintUseColor("red", "请输入绿灯的时间： ");
                string str = Console.ReadLine();
                if (CheckInput(str))
                {
                    redTime = Convert.ToInt32(str);
                    break;
                }
            }

            //颜色灯交替循环
            while (true)
            {
                //绿灯倒计时
                for (int i = greenTime; i > 0; i--)
                {
                    TrafficLight objTraf = new TrafficLight(i);
                    Console.Clear();
                    objTraf.PrintNumber("green");

                    int action = TrafficLight.Wait();
                    if (action == 1) continue;
                    else if (action == 2) goto ReInput;
                    else if (action == 3) goto End;
                }
                //黄灯倒计时
                for (int i = yellowTime; i > 0; i--)
                {
                    TrafficLight objTraf = new TrafficLight(i);
                    Console.Clear();
                    objTraf.PrintNumber("yellow");

                    int action = TrafficLight.Wait();
                    if (action == 1) continue;
                    else if (action == 2) goto ReInput;
                    else if (action == 3) goto End;
                }
                //红灯倒计时
                for (int i = redTime; i > 0; i--)
                {
                    TrafficLight objTraf = new TrafficLight(i);
                    Console.Clear();
                    objTraf.PrintNumber("red");

                    int action = TrafficLight.Wait();
                    if (action == 1) continue;
                    else if (action == 2) goto ReInput;
                    else if (action == 3) goto End;
                }
            }
            End:
            Console.WriteLine("\n");
            PrintCustom.PrintUseColor("red", "程序退出，按任意键结束！");
            Console.ReadKey();
        }
        static bool CheckInput(string txt)
        {
            if(string.IsNullOrEmpty(txt))
            {
                Console.Write("没有输入任何值，请重新输入！");
                return false;
            }
            if (!Validata.IsNumber(txt))
            {
                Console.Write("必须输入数字！");
                return false;
            }
            if (Convert.ToInt32(txt) < 0 || Convert.ToInt32(txt) > 99)
            {
                Console.Write("输入数字必须在0-99之间！");
                return false;
            }
            return true;
        }
    }
}
