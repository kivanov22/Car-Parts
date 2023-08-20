namespace CarParts.API.Core.ViewModels.Parts
{
    public class PartsQueryModel
    {
        public int CurrentPage { get; init; } = 1;
        public int PartsPerPage { get; init; } = 10;

        public int TotalParts { get; set; }
        public string SearchParams { get; set; }

        public PartSorting Sorting { get; init; }
        public IEnumerable<AllPartsDto> Parts { get; set; }

    }
}
