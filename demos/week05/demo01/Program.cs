namespace demo01;

using System.IO;

public class Player {
    public int Score { get; set; }
    public string Name { get; set; }
    
    public Player(string name, int score)
    {
        Score = score;
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Player[] players = new Player[] {
          new Player("Fred", 100),  
          new Player("Alice", 500),  
          new Player("Bob", 200),  
        };

        StreamWriter wr = new StreamWriter("LeaderBoard.txt");
        for(int i = 0; i < players.Length; i++)
        {
            Player p = players[i];
            string player = p.Name;
            int score = p.Score;

            string formatted = player + ":" + score;
            wr.WriteLine(formatted);
        }

        wr.Close();
        
    }
    // static void Main(string[] args)
    // {
    //     using(StreamReader reader = new StreamReader("addressbook.csv"))
    //     {

    //         string? line = reader.ReadLine();

    //         while(line != null)
    //         {
    //             Console.WriteLine(line);
    //             line = reader.ReadLine();
    //         }
    //     }
    // }
}
