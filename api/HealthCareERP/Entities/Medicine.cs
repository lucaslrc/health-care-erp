using System.ComponentModel.DataAnnotations;

namespace HealthCareERP.Entities
{
    public class Medicine
    {
        [Key]
        public long ID { get; set; }

        public string LoteID { get; set; }

        public string Substancia { get; set; }

        public int Amount { get; set; }

        public string Cnpj { get; set; }

        public string Laboratorio { get; set; }

        public string CodigoGgrem { get; set; }

        public string Registro { get; set; }

        public string Ean1 { get; set; }

        public string Ean2 { get; set; }

        public string Ean3 { get; set; }

        public string Produto { get; set; }

        public string Apresentacao { get; set; }

        public string ClasseTerapeutica { get; set; }

        public string TipoProduto { get; set; }

        public string RegimePreco { get; set; }

        public string PfSemImpostos { get; set; }

        // PF 0%
        public string Pf0 { get; set; }

        // PF 12%
        public string Pf12 { get; set; }

        // PF 17%
        public string Pf17 { get; set; }

        // PF 17% ALC
        public string Pf17Alc { get; set; }

        // PF 17,5%
        public string Pf175 { get; set; }

        // PF 17,5% ALC
        public string Pf175Alc { get; set; }

        // PF 18%
        public string Pf18 { get; set; }

        // PF 18% ALC
        public string Pf18Alc { get; set; }

        // PF 20%
        public string Pf20 { get; set; }
        
        // PMC 0%
        public string Pmc0 { get; set; }

        // PMC 12%
        public string Pmc12 { get; set; }

        // PMC 17%
        public string Pmc17 { get; set; }

        // PMC 17% ALC
        public string Pmc17Alc { get; set; }

        // PMC 17,5%
        public string Pmc175 { get; set; }

        // PMC 17,5% ALC
        public string Pmc175Alc { get; set; }

        // PMC 18%
        public string Pmc18 { get; set; }

        // PMC 18% ALC
        public string Pmc18Alc { get; set; }

        // PMC 20%
        public string Pmc20 { get; set; }

        public string RestricaoHospitalar { get; set; }
        
        public string Cap { get; set; }

        public string Confaz87 { get; set; }

        // ICMS 0%
        public string Icms0 { get; set; }

        public string AnaliseRecursal { get; set; }

        public string ListaConcessaoCreditoTributario { get; set; }

        public string Comercializacao2019 { get; set; }

        public string Tarja { get; set; }
    }
}