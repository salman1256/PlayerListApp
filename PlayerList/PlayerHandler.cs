using System.Linq;
namespace PlayerList
{
    public static class PlayerHandler
    {
        static List<Player> listPlayers=new List<Player>
        {
            new Player{Id=1,Name="MSD",Team="CSK"},
             new Player{Id=2,Name="Virat Kohli",Team="RCB"},
             new Player{Id=3,Name="M.Siraj",Team="GT"},
             new Player{Id=10,Name="Smriti Mandhana",Team="RCB"}

        };
        public static  Player PlayerDetails(int id)
        {
          var player=listPlayers.SingleOrDefault(e=>e.Id==id);
          if(player!=null)
          {
            System.Console.WriteLine("Found");
            
          }
          else{
            System.Console.WriteLine("Not Found");
          }
          return player;

        }
        public static  List<Player> AllPlayers()
        {
            return listPlayers;
        }

    }

}