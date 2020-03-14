using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Class4
{
    public class AlarmArgs : EventArgs
    {
        public DateTime alarmTime;
    }

    public delegate void TimeHandler(object sender, AlarmArgs e);

    public class Alarm
    {
        public event TimeHandler Alarming;
        public event TimeHandler Ticking;
        private DateTime alarmTime;
        public void SetAlarm(DateTime alarm)
        {
            this.alarmTime = alarm;
        }
        public void AlarmTicking()
        {
            while (true)
            {
                AlarmArgs args = new AlarmArgs();
                args.alarmTime = alarmTime;
                TimeSpan ts = DateTime.Now - alarmTime;

                Ticking(this, args);//Ticking
                if (ts.Seconds==0)
                {//Alarming
                    Alarming(this, args);
                }
            }
        }
    }


    class UsrAlarm
    {
        static void Main(string[] args)
        {
            var alarm = new Alarm();
            alarm.Alarming += ShowAlarm;
            alarm.Ticking += ShowTick;
            DateTime alarmTime=new DateTime();
            Console.WriteLine("现在的时间是：" + DateTime.Now+"\n"+"请严格按照上述日期格式输入（请使用英文输入法）");
            Console.WriteLine("请设置闹钟时间（若输入错误的时间默认 闹钟定为10s后）：");
            try
            {
                alarmTime = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                alarmTime = DateTime.Now.AddSeconds(10);
                Console.WriteLine("输入格式错误,闹钟自动设置为10s后");
            }
            alarm.SetAlarm(alarmTime);
            Console.WriteLine("滴答滴答。。。时间正一分一秒过去");
            alarm.AlarmTicking();


            Console.ReadLine();
            Console.ReadLine();
        }
        public static void ShowTick(object sender, AlarmArgs e)
        {
            Console.WriteLine(DateTime.Now);
            Thread.Sleep(1000);
            
        }

        public static void ShowAlarm(object sender,AlarmArgs e)
        {
            Console.WriteLine("Alarming!!! Current Time is "+e.alarmTime);
        }
    }


     /*class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }*/
}
