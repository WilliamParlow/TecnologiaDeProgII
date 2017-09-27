namespace DojoArtesMaciais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAlunos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunoes (Nome, Cpf, FaixaId, Faixa_Id, TipoDeAssociacaoId, TipoDeAssociacao_Id) VALUES('Martim Castro Ribeiro', '158.778.735-04', 15, 15, 2, 2)");
            Sql("INSERT INTO Alunoes (Nome, Cpf, FaixaId, Faixa_Id, TipoDeAssociacaoId, TipoDeAssociacao_Id) VALUES('Lucas Alves Melo', '916.749.332-74', 18, 18, 4, 4)");
            Sql("INSERT INTO Alunoes (Nome, Cpf, FaixaId, Faixa_Id, TipoDeAssociacaoId, TipoDeAssociacao_Id) VALUES('Breno Castro Carvalho', '454.019.800-94', 16, 16, 3, 3)");
            Sql("INSERT INTO Alunoes (Nome, Cpf, FaixaId, Faixa_Id, TipoDeAssociacaoId, TipoDeAssociacao_Id) VALUES('Laura Cardoso Rocha', '361.089.665-56', 20, 20, 5, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
