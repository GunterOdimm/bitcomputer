using System;
using static System.Console;

namespace Project1
{
    class car
    {
        private String model;
        private String color;

        public car()
        {
            model = "임팔라";
            color = "아이보리";
        }

        public car(String m, String c)
        {
            model = m;
            color = c;
        }

        public void ShowStatus()
        {
            WriteLine($"Model : {model},        Color : {color}");
        }


        ~car()
        {
            WriteLine("소멸자 실행");
        }
    }

}
