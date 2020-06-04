using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.IO;

namespace football
{
    class Match
    {
        protected Team team1; 
        protected Team team2;
        protected Date date;
        protected int goal1;
        protected int goal2;


        public Match() { }

        public void SetDate(int dd, int mm, int yy)
        {
            date = new Date(dd, mm, yy);
        }

        public static Was MatchToWas(Match match, int goal1, int goal2)
        {
            Was was = new Was(match.Date, match.Team1, goal1, goal2, match.Team2);
            return was;
        }

        public Date Date
        {
            get { return date; }
            set { date = value; }
        }

        public Team Team1
        {
            get { return team1; }
            set { team1 = value; }
        }
        public Team Team2
        {
            get { return team2; }
            set { team2 = value; }
        }

        public int Goal1
        {
            get { return goal1; }
            set { goal1 = value; }
        }
        public int Goal2
        {
            get { return goal2; }
            set { goal2 = value; }
        }
    }

    class Was : Match
    {
        public Was() { }

        public Was(Date dat, Team tem1, int gol1, int gol2, Team tem2)
        {
            date = dat;
            team1 = tem1;
            goal1 = gol1;
            goal2 = gol2;
            team2 = tem2;
        }

        public override string ToString()
        {
            return date.ToString() + "\t---\t" + team1.Name + "  \t| " + goal1 + ":" + goal2 + " |  \t" + team2.Name;
        }
    }

    class Will : Match
    {
        public Will(Date dat, Team tem1, Team tem2)
        {
            date = dat;
            team1 = tem1;
            team2 = tem2;
        }

        public override string ToString()
        {
            return date.ToString() + "\t---\t" + team1.Name + "  \t| -:- |  \t" + team2.Name;
        }
    }

}
