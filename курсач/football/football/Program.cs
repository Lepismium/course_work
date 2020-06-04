using System;
using System.Dynamic;
using System.Threading;

namespace football
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                bool x = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("________________Клуб футбольных фанатов_________________\n\n");
                    Console.WriteLine(" 1 – войти как гость\n\n 2 – войти как администратор\n\n 3 - инструкция");
                    char t1 = Console.ReadKey().KeyChar;
                    if (t1 == '1')
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите команду:\n\n\n1 – Динамо\n\n2 – Шахтер");
                            char t2 = Console.ReadKey().KeyChar;
                            if (t2 == '1')
                            {
                                do
                                {
                                    Console.Clear();
                                    Team dynamo = new Team("Динамо");
                                    dynamo.InitPlayers("../../../files/dyn/");
                                    dynamo.SetInfo("../../../files/dynamo.txt");
                                    dynamo.SetPlayersInfo("../../../files/dyn/");
                                    Console.WriteLine(" 1 – показать список игроков\n 2 – показать информацию об игроке по его номеру\n 3 – показать информацию о команде\n 4 – узнать историю матчей команды за 2019 – 2020 года\n 5 – новости об анонсах матчей команды");
                                    char t3 = Console.ReadKey().KeyChar;
                                    if (t3 == '1')
                                    {
                                        Console.Clear();
                                        Console.WriteLine(dynamo.GetPlayers());
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;

                                    }
                                    else if (t3 == '2')
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите номер игрока: ");
                                        Console.WriteLine(dynamo[Convert.ToInt32(Console.ReadLine())].Info);
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;
                                    }
                                    else if (t3 == '3')
                                    {
                                        Console.Clear();
                                        Console.WriteLine(dynamo.Info);
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;
                                    }
                                    else if (t3 == '4')
                                    {
                                        Console.Clear();
                                        LinkedList<Match> matches = History.Init("../../../files/match_dynamo_was.txt");
                                        for (int i = 0; i < matches.Size; i++)
                                        {
                                            Console.WriteLine(matches[i]);
                                        }
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;
                                    }
                                    else if (t3 == '5')
                                    {
                                        Console.Clear();
                                        LinkedList<Match> matches = Announcement.Init("../../../files/match_dynamo_will.txt");
                                        for (int i = 0; i < matches.Size; i++)
                                        {
                                            Console.WriteLine(matches[i]);
                                        }
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;
                                    }
                                    else if (t3 == '/')
                                        break;
                                } while (x);

                            }
                            else if (t2 == '2')
                            {
                                do
                                {
                                    Console.Clear();
                                    Team shahter = new Team("Шахтер");
                                    shahter.InitPlayers("../../../files/shah/");
                                    shahter.SetInfo("../../../files/shahter.txt");
                                    shahter.SetPlayersInfo("../../../files/shah/");
                                    Console.WriteLine(" 1 – показать список игроков\n 2 – показать информацию об игроке по его номеру\n 3 – показать информацию о команде\n 4 – узнать историю матчей команды за 2019 – 2020 года\n 5 – новости об анонсах матчей команды");
                                    char t3 = Console.ReadKey().KeyChar;
                                    if (t3 == '1')
                                    {
                                        Console.Clear();
                                        Console.WriteLine(shahter.GetPlayers());
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;

                                    }
                                    else if (t3 == '2')
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите номер игрока: ");
                                        Console.WriteLine(shahter[Convert.ToInt32(Console.ReadLine())].Info);
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;
                                    }
                                    else if (t3 == '3')
                                    {
                                        Console.Clear();
                                        Console.WriteLine(shahter.Info);
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;
                                    }
                                    else if (t3 == '4')
                                    {
                                        Console.Clear();
                                        LinkedList<Match> matches = History.Init("../../../files/match_shahter_was.txt");
                                        for (int i = 0; i < matches.Size; i++)
                                        {
                                            Console.WriteLine(matches[i]);
                                        }
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;
                                    }
                                    else if (t3 == '5')
                                    {
                                        Console.Clear();
                                        LinkedList<Match> matches = Announcement.Init("../../../files/match_shahter_will.txt");
                                        for (int i = 0; i < matches.Size; i++)
                                        {
                                            Console.WriteLine(matches[i]);
                                        }
                                        if (Console.ReadKey().KeyChar == '/')
                                            continue;
                                    }
                                    else if (t3 == '/')
                                        break;
                                } while (x);
                            }
                            else if (t2 == '/')
                                break;
                        } while (x);
                    }
                    else if (t1 == '2')
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("пароль: ");
                            string password = Console.ReadLine();
                            if (password == "mulik")
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Выберите команду:\n\n\n1 – Динамо\n\n2 – Шахтер");
                                    char t2 = Console.ReadKey().KeyChar;
                                    if (t2 == '1')
                                    {
                                        do
                                        {
                                            Console.Clear();
                                            Team dynamo = new Team("Динамо");
                                            string dyn = "../../../files/dyn/";     //!!!!!!!!!!!!!!!!
                                            string info = "../../../files/dynamo.txt";
                                            dynamo.InitPlayers(dyn);
                                            dynamo.SetInfo(info);
                                            dynamo.SetPlayersInfo(dyn);
                                            LinkedList<Match> matches_was = History.Init("../../../files/match_dynamo_was.txt");
                                            LinkedList<Match> matches_will = Announcement.Init("../../../files/match_dynamo_will.txt");
                                            Console.WriteLine(" 1 – показать список игроков\n 2 – показать информацию об игроке по его номеру\n 3 - редактировать информацию об игроке по его номеру\n 4 – показать информацию о команде\n 5 – редактировать информацию о команде\n 6 – узнать историю матчей команды за 2019 – 2020 года\n 7 – новости об анонсах матчей команды\n 8 – редактировать историю матчей команды\n 9 – редактировать анонсы матчей команды");
                                            char t3 = Console.ReadKey().KeyChar;
                                            if (t3 == '1')
                                            {
                                                Console.Clear();
                                                Console.WriteLine(dynamo.GetPlayers());
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;

                                            }
                                            else if (t3 == '2')
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Введите номер игрока: ");
                                                Console.WriteLine(dynamo[Convert.ToInt32(Console.ReadLine())].Info);
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '3')
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Введите номер игрока: ");
                                                string num = Console.ReadLine();
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine(new Text(dyn + num + ".txt"));

                                                    char t4 = Console.ReadKey().KeyChar;
                                                    if (t4 == '-')
                                                    {
                                                        Console.WriteLine("Введите номер строки которую хотите удалить: ");
                                                        Text.DeleteStr(Convert.ToInt32(Console.ReadLine()));
                                                        continue;
                                                    }
                                                    else if (t4 == '+')
                                                    {
                                                        do
                                                        {
                                                            Text.AddText(Console.ReadLine());
                                                        }
                                                        while (Console.ReadKey().KeyChar != '/');
                                                        Console.WriteLine(" ");
                                                        continue;
                                                    }

                                                    else if (t4 == '/')
                                                        break;
                                                } while (x);
                                            }
                                            else if (t3 == '4')
                                            {
                                                Console.Clear();
                                                Console.WriteLine(dynamo.Info);
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '5')
                                            {
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine(new Text(info));

                                                    char t4 = Console.ReadKey().KeyChar;
                                                    if (t4 == '-')
                                                    {
                                                        Console.WriteLine("Введите номер строки которую хотите удалить: ");
                                                        Text.DeleteStr(Convert.ToInt32(Console.ReadLine()));
                                                        continue;
                                                    }
                                                    else if (t4 == '+')
                                                    {
                                                        do
                                                        {
                                                            Text.AddText(Console.ReadLine());
                                                        }
                                                        while (Console.ReadKey().KeyChar != '/');
                                                        Console.WriteLine(" ");
                                                        continue;
                                                    }

                                                    else if (t4 == '/')
                                                        break;
                                                } while (x);
                                            }
                                            else if (t3 == '6')
                                            {
                                                Console.Clear();
                                                
                                                for (int i = 0; i < matches_was.Size; i++)
                                                {
                                                    Console.WriteLine(matches_was[i]);
                                                }
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '7')
                                            {
                                                Console.Clear();
                                                
                                                for (int i = 0; i < matches_will.Size; i++)
                                                {
                                                    Console.WriteLine(matches_will[i]);
                                                }
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '8')
                                            {
                                                Console.Clear();

                                                for (int i = 0; i < matches_was.Size; i++)
                                                {
                                                    Console.WriteLine(matches_was[i]);
                                                }
                                                Console.WriteLine("Введите номер матча который хотите отредактировать: ");
                                                int num = Convert.ToInt32(Console.ReadLine()) - 1;
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("1 - изменить дату \n2 - изменить название первой команды \n3 - изменить название второй команды \n4 - изменить счет\n");
                                                    char t4 = Console.ReadKey().KeyChar;
                                                    if (t4 == '1')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        Console.WriteLine("Введите день: \n");
                                                        int dd = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите месяц: \n");
                                                        int mm = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите год: \n");
                                                        int yy = Convert.ToInt32(Console.ReadLine());
                                                        matches_was[num].SetDate(dd, mm, yy);
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '2')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        Console.WriteLine("Введите желаемое название команды: \n");
                                                        matches_was[num].Team1 = new Team("\"" + Console.ReadLine() + "\"");
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '3')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        Console.WriteLine("Введите желаемое название команды: \n");
                                                        matches_will[num].Team2 = new Team("\"" + Console.ReadLine() + "\"");
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '4')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        Console.WriteLine("Введите счет: \n");
                                                        matches_was[num].Goal1 = Convert.ToInt32(Console.ReadLine());
                                                        matches_was[num].Goal2 = Convert.ToInt32(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '/')
                                                        break;

                                                } while (x);
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '9')
                                            {
                                                Console.Clear();

                                                for (int i = 0; i < matches_will.Size; i++)
                                                {
                                                    Console.WriteLine(matches_will[i]);
                                                }
                                                Console.WriteLine("Введите номер матча который хотите отредактировать: ");
                                                int num = Convert.ToInt32(Console.ReadLine()) - 1;
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("1 - изменить дату \n2 - изменить название первой команды \n3 - изменить название второй команды \n4 - записать счет\n");
                                                    char t4 = Console.ReadKey().KeyChar;
                                                    if (t4 == '1')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        Console.WriteLine("Введите день: \n");
                                                        int dd = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите месяц: \n");
                                                        int mm = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите год: \n");
                                                        int yy = Convert.ToInt32(Console.ReadLine());
                                                        matches_will[num].SetDate(dd, mm, yy);
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '2')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        Console.WriteLine("Введите желаемое название команды: \n");
                                                        matches_will[num].Team1 = new Team("\"" + Console.ReadLine() + "\"");
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '3')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        Console.WriteLine("Введите желаемое название команды: \n");
                                                        matches_will[num].Team2 = new Team("\"" + Console.ReadLine() + "\"");
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '4')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        Console.WriteLine("Введите счет: \n");
                                                        Was was = Match.MatchToWas(matches_will[num], Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                                        Console.Clear();
                                                        Console.WriteLine(was);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '/')
                                                        break;

                                                } while (x);
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '/')
                                                break;
                                        } while (x);

                                    }
                                    else if (t2 == '2')
                                    {
                                        do
                                        {
                                            Console.Clear();
                                            Team shahter = new Team("Шахтер");
                                            string shah = "../../../files/shah/";     //!!!!!!!!!!!!!!!!
                                            string info = "../../../files/shahter.txt";
                                            shahter.InitPlayers(shah);
                                            shahter.SetInfo(info);
                                            shahter.SetPlayersInfo(shah);
                                            LinkedList<Match> matches_was = History.Init("../../../files/match_shahter_was.txt");
                                            LinkedList<Match> matches_will = Announcement.Init("../../../files/match_shahter_will.txt");
                                            Console.WriteLine(" 1 – показать список игроков\n 2 – показать информацию об игроке по его номеру\n 3 - редактировать информацию об игроке по его номеру\n 4 – показать информацию о команде\n 5 – редактировать информацию о команде\n 6 – узнать историю матчей команды за 2019 – 2020 года\n 7 – новости об анонсах матчей команды\n 8 – редактировать историю матчей команды\n 9 – редактировать анонсы матчей команды");
                                            char t3 = Console.ReadKey().KeyChar;
                                            if (t3 == '1')
                                            {
                                                Console.Clear();
                                                Console.WriteLine(shahter.GetPlayers());
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;

                                            }
                                            else if (t3 == '2')
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Введите номер игрока: ");
                                                Console.WriteLine(shahter[Convert.ToInt32(Console.ReadLine())].Info);
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '3')
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Введите номер игрока: ");
                                                string num = Console.ReadLine();
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine(new Text(shah + num + ".txt"));

                                                    char t4 = Console.ReadKey().KeyChar;
                                                    if (t4 == '-')
                                                    {
                                                        Console.WriteLine("Введите номер строки которую хотите удалить: ");
                                                        Text.DeleteStr(Convert.ToInt32(Console.ReadLine()));
                                                        continue;
                                                    }
                                                    else if (t4 == '+')
                                                    {
                                                        do
                                                        {
                                                            Text.AddText(Console.ReadLine());
                                                        }
                                                        while (Console.ReadKey().KeyChar != '/');
                                                        Console.WriteLine(" ");
                                                        continue;
                                                    }

                                                    else if (t4 == '/')
                                                        break;
                                                } while (x);
                                            }
                                            else if (t3 == '4')
                                            {
                                                Console.Clear();
                                                Console.WriteLine(shahter.Info);
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '5')
                                            {
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine(new Text(info));

                                                    char t4 = Console.ReadKey().KeyChar;
                                                    if (t4 == '-')
                                                    {
                                                        Console.WriteLine("Введите номер строки которую хотите удалить: ");
                                                        Text.DeleteStr(Convert.ToInt32(Console.ReadLine()));
                                                        continue;
                                                    }
                                                    else if (t4 == '+')
                                                    {
                                                        do
                                                        {
                                                            Text.AddText(Console.ReadLine());
                                                        }
                                                        while (Console.ReadKey().KeyChar != '/');
                                                        Console.WriteLine(" ");
                                                        continue;
                                                    }

                                                    else if (t4 == '/')
                                                        break;
                                                } while (x);
                                            }
                                            else if (t3 == '6')
                                            {
                                                Console.Clear();
                                                
                                                for (int i = 0; i < matches_was.Size; i++)
                                                {
                                                    Console.WriteLine(matches_was[i]);
                                                }
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '7')
                                            {
                                                Console.Clear();
                                                
                                                for (int i = 0; i < matches_will.Size; i++)
                                                {
                                                    Console.WriteLine(matches_will[i]);
                                                }
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '8')
                                            {
                                                Console.Clear();

                                                for (int i = 0; i < matches_was.Size; i++)
                                                {
                                                    Console.WriteLine(matches_was[i]);
                                                }
                                                Console.WriteLine("Введите номер матча который хотите отредактировать: ");
                                                int num = Convert.ToInt32(Console.ReadLine()) - 1;
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("1 - изменить дату \n2 - изменить название первой команды \n3 - изменить название второй команды \n4 - изменить счет\n");
                                                    char t4 = Console.ReadKey().KeyChar;
                                                    if (t4 == '1')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        Console.WriteLine("Введите день: \n");
                                                        int dd = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите месяц: \n");
                                                        int mm = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите год: \n");
                                                        int yy = Convert.ToInt32(Console.ReadLine());
                                                        matches_was[num].SetDate(dd, mm, yy);
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '2')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        Console.WriteLine("Введите желаемое название команды: \n");
                                                        matches_was[num].Team1 = new Team("\"" + Console.ReadLine() + "\"");
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '3')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        Console.WriteLine("Введите желаемое название команды: \n");
                                                        matches_will[num].Team2 = new Team("\"" + Console.ReadLine() + "\"");
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '4')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_was[num]);
                                                        Console.WriteLine("Введите счет: \n");
                                                        matches_was[num].Goal1 = Convert.ToInt32(Console.ReadLine());
                                                        matches_was[num].Goal2 = Convert.ToInt32(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '/')
                                                        break;

                                                } while (x);
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '9')
                                            {
                                                Console.Clear();
                                                
                                                for (int i = 0; i < matches_will.Size; i++)
                                                {
                                                    Console.WriteLine(matches_will[i]);
                                                }
                                                Console.WriteLine("Введите номер матча который хотите отредактировать: ");
                                                int num = Convert.ToInt32(Console.ReadLine()) - 1;
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("1 - изменить дату \n2 - изменить название первой команды \n3 - изменить название второй команды \n4 - записать счет\n");
                                                    char t4 = Console.ReadKey().KeyChar;
                                                    if (t4 == '1')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        Console.WriteLine("Введите день: \n");
                                                        int dd = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите месяц: \n");
                                                        int mm = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите год: \n");
                                                        int yy = Convert.ToInt32(Console.ReadLine());
                                                        matches_will[num].SetDate(dd, mm, yy);
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '2')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        Console.WriteLine("Введите желаемое название команды: \n");
                                                        matches_will[num].Team1 = new Team("\"" + Console.ReadLine() + "\"");
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '3')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        Console.WriteLine("Введите желаемое название команды: \n");
                                                        matches_will[num].Team2 = new Team("\"" + Console.ReadLine() + "\"");
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '4')
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(matches_will[num]);
                                                        Console.WriteLine("Введите счет: \n");
                                                        Was was = Match.MatchToWas(matches_will[num], Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                                                        Console.Clear();
                                                        Console.WriteLine(was);
                                                        if (Console.ReadKey().KeyChar == '/')
                                                            continue;
                                                    }
                                                    else if (t4 == '/')
                                                        break;

                                                } while (x);
                                                if (Console.ReadKey().KeyChar == '/')
                                                    continue;
                                            }
                                            else if (t3 == '/')
                                                break;
                                        } while (x);

                                    }
                                    else if (t2 == '/')
                                        break;
                                } while (x);
                            }
                            else if (password == "/")
                                break;
                            else
                            {
                                Console.WriteLine("Неверный пароль.");
                                Thread.Sleep(1000);
                            }    
                                
                        } while (x);
                    }
                    else if (t1 == '3')
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Нажимайте цифры в соответствии с указаниями. \nЧтобы вернуться назад нажмите \"/\" \nВ режиме редактирования нажмите \"+\" чтобы ввести новую строку \nили \"-\" чтобы удалить строку по номеру");
                            if (Console.ReadKey().KeyChar == '/')
                                break;
                        } while (x);
                    }
                    else if (t1 == '/')
                        break;
                    

                } while (x);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Игрока с таким номером не существует.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
