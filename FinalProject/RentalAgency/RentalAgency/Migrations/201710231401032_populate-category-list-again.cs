namespace RentalAgency.Migrations {
   using System;
   using System.Data.Entity.Migrations;

   public partial class populatecategorylistagain : DbMigration {
      public override void Up() {

         Sql("INSERT INTO Categories VALUES ('Ação')");
         Sql("INSERT INTO Categories VALUES ('Animação')");
         Sql("INSERT INTO Categories VALUES ('Aventura')");
         Sql("INSERT INTO Categories VALUES ('Chanchada')");
         Sql("INSERT INTO Categories VALUES ('Cinema catástrofe')");
         Sql("INSERT INTO Categories VALUES ('Comédia')");
         Sql("INSERT INTO Categories VALUES ('Comédia romântica')");
         Sql("INSERT INTO Categories VALUES ('Comédia dramática')");
         Sql("INSERT INTO Categories VALUES ('Comédia de ação')");
         Sql("INSERT INTO Categories VALUES ('Cult')");
         Sql("INSERT INTO Categories VALUES ('Dança')");
         Sql("INSERT INTO Categories VALUES ('Documentários')");
         Sql("INSERT INTO Categories VALUES ('Drama')");
         Sql("INSERT INTO Categories VALUES ('Espionagem')");
         Sql("INSERT INTO Categories VALUES ('Erótico')");
         Sql("INSERT INTO Categories VALUES ('Fantasia')");
         Sql("INSERT INTO Categories VALUES ('Faroeste')");
         Sql("INSERT INTO Categories VALUES ('Ficção científica')");
         Sql("INSERT INTO Categories VALUES ('Séries')");
         Sql("INSERT INTO Categories VALUES ('Guerra')");
         Sql("INSERT INTO Categories VALUES ('Machinima')");
         Sql("INSERT INTO Categories VALUES ('Masala')");
         Sql("INSERT INTO Categories VALUES ('Musical')");
         Sql("INSERT INTO Categories VALUES ('Filme noir')");
         Sql("INSERT INTO Categories VALUES ('Policial')");
         Sql("INSERT INTO Categories VALUES ('Pornochanchada')");
         Sql("INSERT INTO Categories VALUES ('Pornográfico')");
         Sql("INSERT INTO Categories VALUES ('Romance')");
         Sql("INSERT INTO Categories VALUES ('Seriado')");
         Sql("INSERT INTO Categories VALUES ('Suspense')");
         Sql("INSERT INTO Categories VALUES ('Horror')");
         Sql("INSERT INTO Categories VALUES ('Trash')");

      }

      public override void Down() {
      }
   }
}
