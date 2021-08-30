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

        public long CodigoGgrem { get; set; }

        public long Registro { get; set; }

        public long Ean1 { get; set; }

        public long Ean2 { get; set; }

        public long Ean3 { get; set; }

        public string Produto { get; set; }

        public string Apresentacao { get; set; }

        public string ClasseTerapeutica { get; set; }

        public string TipoProduto { get; set; }

        public string RegimePreco { get; set; }

        public double PfSemImpostos { get; set; }

        // PF 0%
        public double Pf0 { get; set; }

        // PF 12%
        public double Pf12 { get; set; }

        // PF 17%
        public double Pf17 { get; set; }

        // PF 17% ALC
        public double Pf17Alc { get; set; }

        // PF 17,5%
        public double Pf175 { get; set; }

        // PF 17,5% ALC
        public double Pf175Alc { get; set; }

        // PF 18%
        public double Pf18 { get; set; }

        // PF 18% ALC
        public double Pf18Alc { get; set; }

        // PF 20%
        public double Pf20 { get; set; }
        
        // PMC 0%
        public double Pmc0 { get; set; }

        // PMC 12%
        public double Pmc12 { get; set; }

        // PMC 17%
        public double Pmc17 { get; set; }

        // PMC 17% ALC
        public double Pmc17Alc { get; set; }

        // PMC 17,5%
        public double Pmc175 { get; set; }

        // PMC 17,5% ALC
        public double Pmc175Alc { get; set; }

        // PMC 18%
        public double Pmc18 { get; set; }

        // PMC 18% ALC
        public double Pmc18Alc { get; set; }

        // PMC 20%
        public double Pmc20 { get; set; }

        public string RestricaoHospitalar { get; set; }
        
        public string Cap { get; set; }

        public string Confaz87 { get; set; }

        // ICMS 0%
        public string Icms0 { get; set; }

        public string AnaliseRecursal { get; set; }

        public string ListaConcessaoCreditoTributario { get; set; }

        public string Comercializacao2020 { get; set; }

        public string Tarja { get; set; }
    }
}