using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DojoArtesMaciais.Models {
    public class TipoDeAssociacao {

        public short Id { get; set; }
        public String Nome { get; set; }
        public int Periodo { get; set; }
        public int Mensalidade { get; set; }

    }
}