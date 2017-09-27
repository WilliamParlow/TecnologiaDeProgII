namespace DojoArtesMaciais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionarDadosNasTabelas : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Faixas (Nome, Grau) values('Branca', '6k')");
            Sql("INSERT INTO Faixas (Nome, Grau) values('Amarela', '5k')");
            Sql("INSERT INTO Faixas (Nome, Grau) values('Roxa', '4k')");
            Sql("INSERT INTO Faixas (Nome, Grau) values('Verde', '3k')");
            Sql("INSERT INTO Faixas (Nome, Grau) values('Azul', '2k')");
            Sql("INSERT INTO Faixas (Nome, Grau) values('Marrom', '1k')");
            Sql("INSERT INTO Faixas (Nome, Grau) values('Preta', '1d')");

            Sql("INSERT INTO TipoDeAssociacaos (Nome, Periodo, Mensalidade) values('Mensal', 1, 140)");
            Sql("INSERT INTO TipoDeAssociacaos (Nome, Periodo, Mensalidade) values('Trimestral', 3, 400)");
            Sql("INSERT INTO TipoDeAssociacaos (Nome, Periodo, Mensalidade) values('Semestral', 6, 600)");
            Sql("INSERT INTO TipoDeAssociacaos (Nome, Periodo, Mensalidade) values('Anual', 12, 1400)");

        }
        
        public override void Down()
        {
        }
    }
}
