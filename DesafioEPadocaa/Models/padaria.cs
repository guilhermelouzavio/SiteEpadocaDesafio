using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioEPadocaa.Models
{
    public class padaria
    {
        [Key]
        public int codigo { get; set; }
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string nome{ get; set; }
        public int telefone { get; set; }
        public string endereco { get; set; }
        [Index("cnpj", IsUnique = true)]
        public int cnpj { get; set; }
    }
}

