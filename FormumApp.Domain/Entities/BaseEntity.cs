using System;

namespace FormumApp.Domain.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime InsertDate  { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }
        public string InsertedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}