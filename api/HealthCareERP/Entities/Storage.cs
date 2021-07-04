using System.Collections.Generic;

namespace HealthCareERP.Entities
{
    public abstract class Storage
    {
        public long ID { get; set; }
        
        public string LoteID { get; set; }

        public List<Medicine> Medicines { get; set; }
    }
}