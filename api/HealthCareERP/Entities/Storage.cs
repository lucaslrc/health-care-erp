using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthCareERP.Entities
{
    public class Storage
    {
        [Key]
        public long ID { get; set; }
        
        public string LoteID { get; set; }

        public List<Medicine> Medicines { get; set; }
    }
}