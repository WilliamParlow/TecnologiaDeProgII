namespace RentalAgency.Migrations {
   using System;
   using System.Data.Entity.Migrations;

   public partial class populatecategorylistagain : DbMigration {
      public override void Up() {

         Sql("INSERT INTO Categories VALUES ('A��o')");
         Sql("INSERT INTO Categories VALUES ('Anima��o')");
         Sql("INSERT INTO Categories VALUES ('Aventura')");
         Sql("INSERT INTO Categories VALUES ('Chanchada')");
         Sql("INSERT INTO Categories VALUES ('Cinema cat�strofe')");
         Sql("INSERT INTO Categories VALUES ('Com�dia')");
         Sql("INSERT INTO Categories VALUES ('Com�dia rom�ntica')");
         Sql("INSERT INTO Categories VALUES ('Com�dia dram�tica')");
         Sql("INSERT INTO Categories VALUES ('Com�dia de a��o')");
         Sql("INSERT INTO Categories VALUES ('Cult')");
         Sql("INSERT INTO Categories VALUES ('Dan�a')");
         Sql("INSERT INTO Categories VALUES ('Document�rios')");
         Sql("INSERT INTO Categories VALUES ('Drama')");
         Sql("INSERT INTO Categories VALUES ('Espionagem')");
         Sql("INSERT INTO Categories VALUES ('Er�tico')");
         Sql("INSERT INTO Categories VALUES ('Fantasia')");
         Sql("INSERT INTO Categories VALUES ('Faroeste')");
         Sql("INSERT INTO Categories VALUES ('Fic��o cient�fica')");
         Sql("INSERT INTO Categories VALUES ('S�ries')");
         Sql("INSERT INTO Categories VALUES ('Guerra')");
         Sql("INSERT INTO Categories VALUES ('Machinima')");
         Sql("INSERT INTO Categories VALUES ('Masala')");
         Sql("INSERT INTO Categories VALUES ('Musical')");
         Sql("INSERT INTO Categories VALUES ('Filme noir')");
         Sql("INSERT INTO Categories VALUES ('Policial')");
         Sql("INSERT INTO Categories VALUES ('Pornochanchada')");
         Sql("INSERT INTO Categories VALUES ('Pornogr�fico')");
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
