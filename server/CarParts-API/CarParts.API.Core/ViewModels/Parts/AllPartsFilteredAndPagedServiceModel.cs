namespace CarParts.API.Core.ViewModels.Parts
{
    public class AllPartsFilteredAndPagedServiceModel
    {
        public AllPartsFilteredAndPagedServiceModel()
        {
            Parts = new HashSet<AllPartsDto>();
        }


        public int TotalPartsCount { get; set; }


        public IEnumerable<AllPartsDto> Parts { get; set; }
    }
}
