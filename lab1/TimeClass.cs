using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class TimeClass
    {
        public int h = 0, m = 0, s = 0;
        //static const int Error = 1; //ошибка
        public TimeClass()
        {
            h = 0;
            m = 0;
            s = 0;
        }//конструктор по умолчанию
        public TimeClass(int h1, int m1, int s1)
        {
            if ((h1 >= 0) && (m1 >= 0) && (s1 >= 0))
            {
                h = h1;
                m = m1;
                s = s1;
            }
            //else
            //{
            //    TimeClass();
            //    throw Error;
            //}
        } //конструктор с параметрами
        public void set_hours(int h1)
        {
            if (h1 >= 0 && h1 < 24)
            {
                h = h1;
            }
        } //ввод часов
        public void set_minutes(int m1)
        {
            if (m >= 0 && m < 60)
                m = m1;
        } //ввод минут
        public void set_seconds(int s1)
        {
            if (s >= 0 && s < 60)
                s = s1;
        } //ввод секунд
        public void addition(int h2, int m2, int s2)
        {
            if ((h2 >= 0) && (h2 < 24) && (m2 >= 0) && (m2 < 60) && (s2 >= 0) && (s2 < 60))
            {
                h += h2;
                m += m2;
                s += s2;

                if (s >= 60)
                {
                    s = s - 60;
                    m = m + 1;
                }
                if (m >= 60)
                {
                    m = m - 60;
                    h = h + 1;
                }
                if (h > 24)
                {
                    h = h - 24;
                }
                if (h == 24)
                    h = 0;
            }
            //else
            //    cout << "Error";
        } //сложение часов, минут, секунд
        public void subtraction(int h2, int m2, int s2)
        {
            if ((h2 >= 0) && (h2 < 24) && (m2 >= 0) && (m2 < 60) && (s2 >= 0) && (s2 < 60))
            {
                h -= h2;
                m -= m2;
                s -= s2;
                if (s < 0)
                {
                    s = s + 60;
                    m = m - 1;
                }
                if (m < 0)
                {
                    m = m + 60;
                    h = h - 1;
                }
                if (h < 0)
                {
                    h = h + 24;
                }
                if (h == 24)
                    h = 0;
            }
        } //вычитание часов, минут, секунд
        public void add_hours(int h2)
        {
            if (h2 >= 0 && h2 < 24)
            {
                h += h2;
                if (h > 24)
                {
                    h = h - 24;
                }
                if (h == 24)
                    h = 0;
            }
        } //добавление часов
        public void add_minutes(int m2)
        {
            if (m2 >= 0 && m2 < 60)
            {
                m += m2;
                if (m >= 60)
                {
                    m = m - 60;
                }
            }
        } //добавление минут
        public void add_seconds(int s2)
        {
            if (s2 >= 0 && s2 < 60)
            {
                s += s2;
                if (s >= 60)
                {
                    s = s - 60;
                }
            }
        } //добавление секунд
        public string convert_to_string()
        {
            string message = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
            return message;
        } //вывод строки
        public int get_hours()
        {
            return h;
        }//возвращение часов
        public int get_minutes()
        {
            return m;
        } //возвращение минут
        public int get_seconds()
        {
            return s;
        } //возвращение секунд

        public static TimeClass operator +(TimeClass time1, TimeClass time2)
        {
            TimeClass time3 = new TimeClass();
            time3.s = time1.s + time2.s;
            time3.m = time1.m + time2.m;
            time3.h = time1.h + time2.h;

            if (time3.s > 59)
            {
                time3.s -= 60;
                time3.m++;
            }
            if (time3.m > 59)
            {
                time3.m -= 60;
                time3.h++;
            }
            if (time3.h > 23)
            {
                time3.h -= 24;
            }
            return time3;
        }

        public static TimeClass operator -(TimeClass time1, TimeClass time2)
        {
            TimeClass time3 = new TimeClass();
            time3.h = time1.h - time2.h;
            time3.m = time1.m - time2.m;
            time3.s = time1.s - time2.s;

            if (time3.s < 0)
            {
                time3.s *= -1;
                time3.s -= 60;
                time3.s *= -1;
                time3.m--;
            }
            if (time3.m < 0)
            {
                time3.m *= -1;
                time3.m -= 60;
                time3.m *= -1;
                time3.h--;
            }
            if (time3.h < 0)
            {
                time3.h += 24;
            }
            return time3;
        }
        public double to_hours()
        {
            return h + m / 60.0 + s / 3600.0;
        }

        public double to_minutes()
        {
            return h * 60.0 + m + s / 60.0;
        }

        public double to_seconds()
        {
            return h * 3600.0 + m * 60.0 + s;
        }
    }
}
