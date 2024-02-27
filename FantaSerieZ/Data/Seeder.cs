using AutoFixture;


namespace FantaSerieZ.Data
{
   public static class Seeder
   {
       public static void Seed(this PlayerManager playerManager)
       {
           if (!playerManager.Player.Any())
           {
               Fixture fixture = new Fixture();
               fixture.Customize<Player>(Player => Player.Without(p => p.TwitchToken));
               //--- The next two lines add 100 rows to your database
               List<Player> Players = fixture.CreateMany<Player>(100).ToList();
               playerManager.AddRange(Players);
               playerManager.SaveChanges();
          }
       }
   }
}