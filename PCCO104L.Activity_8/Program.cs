using System;

namespace PCCO104L.Activity7.QUIAMBAO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nWORLD CLASS ATHLETES");

            Console.WriteLine("\nNBA PLAYERS");
            Console.WriteLine("");

            Player luka = new NBAPlayer("Averaging 34.5 Ppg, 8.8 Rpg, and 9.4 Apg", "Luka Doncic", "SF", "Dallas Mavericks", 77);
            luka.Information();
            luka.SetInjuryStatus(false);
            luka.UpdateAvailability("Available");

            Player kyrie = new NBAPlayer("Averaging 25.6 Ppg, 5.0 Rpg, and 5.2 Apg", "Kyrie Irving", "PG/SG", "Dallas Mavericks", 11);
            kyrie.Information();
            kyrie.SetInjuryStatus(true);
            kyrie.UpdateAvailability("Unavailable");

            Player lebron = new NBAPlayer("Averaging 25.7 Ppg, 7.3 Rpg, and 8.3 Apg", "Lebron James", "SF/PF", "Los Angeles Lakers", 23);
            lebron.Information();
            lebron.SetInjuryStatus(false);
            lebron.UpdateAvailability("Available");

            Console.WriteLine("\nSOCCER PLAYERS");
            Console.WriteLine("");

            Player messi = new SoccerPlayer("Averaging 1.1 Goals per game", "Lionel Messi", "Forward", "PSG", 10);
            messi.Information();
            messi.SetInjuryStatus(false);
            messi.UpdateAvailability("Available");

            Player ronaldo = new SoccerPlayer("Averaging 0.9 Goals per game", "Cristiano Ronaldo", "Forward", "Al-Nassr", 7);
            ronaldo.Information();
            ronaldo.SetInjuryStatus(true);
            ronaldo.UpdateAvailability("Unavailable");

            Console.WriteLine("\nBASEBALL PLAYERS");
            Console.WriteLine("");

            Player trout = new BaseballPlayer("Averaging .300 Batting Average", "Mike Trout", "Center Fielder", "Los Angeles Angels", 27);
            trout.Information();
            trout.SetInjuryStatus(false);
            trout.UpdateAvailability("Available");

            Player judge = new BaseballPlayer("Averaging .287 Batting Average", "Aaron Judge", "Right Fielder", "New York Yankees", 99);
            judge.Information();
            judge.SetInjuryStatus(true);
            judge.UpdateAvailability("Unavailable");
        }
    }

    public abstract class Player
    {
        public string PlayerName { get; set; }
        public string Statistics { get; }
        public int JerseyNumber { get; set; }
        private string Team { get; set; }
        private string Position { get; set; }
        private bool IsInjured { get; set; }
        public string Availability { get; set; }

        protected Player(string stats, string playerName, string position, string team, int jerseyNumber)
        {
            PlayerName = playerName;
            Position = position;
            Team = team;
            JerseyNumber = jerseyNumber;
            Statistics = stats;
        }

        public void Information()
        {
            Console.WriteLine($"{PlayerName} - Jersey Number: {JerseyNumber}, Team: {Team}, Position: {Position}, Statistics: {Statistics}");
        }

        public void SetInjuryStatus(bool isInjured)
        {
            IsInjured = isInjured;
            Console.WriteLine($"{PlayerName} is {(IsInjured ? "injured" : "not injured")}");
        }

        public void UpdateAvailability(string newAvailability)
        {
            Availability = newAvailability;
            Console.WriteLine($"{PlayerName}'s Availability updated to {Availability}.");
        }
    }


    public class NBAPlayer : Player
    {
        public NBAPlayer(string stats, string playerName, string position, string team, int jerseyNumber)
            : base(stats, playerName, position, team, jerseyNumber)
        {
        }
    }


    public class SoccerPlayer : Player
    {
        public SoccerPlayer(string stats, string playerName, string position, string team, int jerseyNumber)
            : base(stats, playerName, position, team, jerseyNumber)
        {
        }
    }


    public class BaseballPlayer : Player
    {
        public BaseballPlayer(string stats, string playerName, string position, string team, int jerseyNumber)
            : base(stats, playerName, position, team, jerseyNumber)
        {
        }
    }
}
