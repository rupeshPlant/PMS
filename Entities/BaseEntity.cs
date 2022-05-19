namespace Entities
{
    public class BaseEntity
    {
        public string InsertPersonId { get; set; }
        public DateTimeOffset InsertDate { get; set; }

        public string UpdatePersonId { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

    }
}