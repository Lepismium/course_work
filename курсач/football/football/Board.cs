using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace football
{
    class Board
    {
        protected static LinkedList<Match> matches = new LinkedList<Match>();
        protected static int size;

        public int Size
        {
            get { return size; }
        }
    }

    class History : Board
    {
        public static LinkedList<Match> Init(string way)
        {
            matches = new LinkedList<Match>();
            size = 0;
                using (StreamReader sr = new StreamReader(way))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] splitLine = line.Split('.');
                        Date date = new Date(Convert.ToInt32(splitLine[0]), Convert.ToInt32(splitLine[1]), Convert.ToInt32(splitLine[2]));
                        Team team1 = new Team(sr.ReadLine());
                        string[] count = sr.ReadLine().Split(" : ");
                        int goal1 = Convert.ToInt32(count[0]);
                        int goal2 = Convert.ToInt32(count[1]);
                        Team team2 = new Team(sr.ReadLine());
                        matches.push_back(new Was(date, team1, goal1, goal2, team2));
                        size++;
                    }
                }
            return matches;
        }
    }

    class Announcement : Board
    {
        public static LinkedList<Match> Init(string way)
        {
            matches = new LinkedList<Match>();
            size = 0;
                using (StreamReader sr = new StreamReader(way))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] splitLine = line.Split('.');
                        Date date = new Date(Convert.ToInt32(splitLine[0]), Convert.ToInt32(splitLine[1]), Convert.ToInt32(splitLine[2]));
                        Team team1 = new Team(sr.ReadLine());
                        sr.ReadLine();
                        Team team2 = new Team(sr.ReadLine());
                        matches.push_back(new Will(date, team1, team2));
                        size++;
                    }
                }
            return matches;
        }
    }
}
