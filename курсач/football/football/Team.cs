using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace football
{
    class Team
    {
        private LinkedList<Player> team = new LinkedList<Player>();
        private string name;
        private string info;

        public Team(string name)
        {
            this.name = name;
        }

        public Team(string name, LinkedList<Player> players)
        {
            this.name = name;
            team = players;
        }

        public void InitPlayers(string way)
        {
                for (int i = 0; i < 100; i++)
                {
                    string path = way + i + ".txt";
                    if (File.Exists(path))
                    {
                        using (StreamReader sr = new StreamReader(path))
                        {
                            team.push_back(new Player(sr.ReadLine().ToString(), i));
                        }
                    }
                }
        }

        public void SetInfo(string way)
        {
            info = new Text(way).ToString();
        }

        public void SetPlayersInfo(string way)
        {
            for (int i = 0; i < team.Size; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    string path = way + j + ".txt";
                    if (team[i].Number == j || File.Exists(path))
                    {
                        team[i].Info = new Text(path).ToString();
                    }
                }
            }
        }

        public string Name
        {
            get { return name; }
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

        public string GetPlayers()
        {
            string s = null;
            for (int i = 0; i < team.Size; i++)
            {
                s += "\n" + team[i].Number + " " + team[i].Name + "\n";
            }
            return s;
        }

        public Player this[int index]
        {
            get
            {
                int num = 1000;
                for (int i = 0; i < team.Size; i++)
                {
                    if(team[i].Number == index)
                    {
                        num = i;
                    }
                }
                if (num == 1000)
                    throw new IndexOutOfRangeException();
                else
                    return team[num];
            }
        }

        public override string ToString()
        {
            string s = "Название команды: " + name + "\n\nИнформация о команде:\n\n" + info.ToString() + "\n\nПолный список игроков:\n";
            for(int i = 0; i < team.Size; i++)
            {
                s += "\n" + team[i].Number + " " + team[i].Name + "\n";
            }
            return s;
        }
    }
}
