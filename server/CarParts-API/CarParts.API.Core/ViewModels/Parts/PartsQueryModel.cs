using System.ComponentModel.DataAnnotations;

namespace CarParts.API.Core.ViewModels.Parts
{
    public class PartsQueryModel
    {
        public PartsQueryModel()
        {
            CurrentPage = 1;
            PartsPerPage = 10;


            Parts = new HashSet<AllPartsDto>();
        }


        public int CurrentPage { get; init; } = 1;

        [Display(Name ="Show Parts on Page")]
        public int PartsPerPage { get; init; } = 10;

        public string? Category { get; set; }

        [Display(Name = "Search by word")]
        public string? SearchParams { get; set; }

        public int TotalParts { get; set; }

        [Display(Name ="Sort Parts By")]
        public PartSorting PartSorting { get; init; }
        public IEnumerable<AllPartsDto> Parts { get; set; }

    }
}
