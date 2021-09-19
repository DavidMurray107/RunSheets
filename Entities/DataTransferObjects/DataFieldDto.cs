namespace Entities.DataTransferObjects
{
    public class DataFieldDto
    {
        public int ID { get; set; }
        public string Datakey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public decimal MaxValue { get; set; }
        public decimal MinValue { get; set; }
        public int isVisible { get; set; }
        public string CssClass { get; set; }
        public int SubSectionID { get; set; }
        
        public SubSectionDto SubSection { get; set; }

    }
}
