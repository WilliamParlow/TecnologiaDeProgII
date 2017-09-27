using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DojoArtesMaciais.Models {
    public class Aluno {

        public long Id { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public Faixa Faixa { get; set; }
        public TipoDeAssociacao TipoDeAssociacao { get; set; }


    }
}