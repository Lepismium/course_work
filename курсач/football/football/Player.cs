using System;
using System.Collections.Generic;
using System.Text;

namespace football
{
    class Player
    {
        private string name;
        private int number;
        private string info;

        public Player() { }

        public Player(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public string Name
        {
            get { return name; }
        }
        public int Number
        {
            get { return number; }
        }

        public string Info
        {
            get
            {
                if (info != null)
                    return info;
                else
                    return "Информация отсутствует.";
            }
            set { info = value; }
        }

        public override string ToString()
        {
            return "Имя: " + name + "\nНомер: " + number.ToString() + "\n\nИнформация об игроке: " + info.ToString();
        }
    }
}
