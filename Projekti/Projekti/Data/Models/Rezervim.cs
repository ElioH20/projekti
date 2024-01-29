using Projekti.Base;

namespace Projekti.Data.Models
{
    public class Rezervim: EntityBase
    {
        public int ID {  get; set; }

        public string Emri {  get; set; }

        public string Desc {  get; set; }

        public DateTime Koha {  get; set; }

        public string Location { get; set; }   
    }
}
