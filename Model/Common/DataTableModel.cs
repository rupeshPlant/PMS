namespace Models.Common
{
    public class DataTableRequestModel
    {
        public int Id { get; set; }
        public string Draw { get; set; }
        public string Start { get; set; }
        public string Length { get; set; }
        public string SortColumn { get; set; }
        public string SortColumnDirection { get; set; }
        public string SearchValue { get; set; }

    }

    public class DataTableResponseModel<T>
    {
        public string Draw { get; set; }
        public string RecordsFiltered { get; set; }
        public string RecordsTotal { get; set; }

        public List<T> Data { get; set; } = new List<T>();

    }
}
