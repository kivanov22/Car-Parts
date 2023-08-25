using AutoMapper;
using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Core.Interfaces;
using CarParts.API.Core.ViewModels.Parts;
using CarParts.API.Infrastructure.Data;
using CarParts.API.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CarParts.API.Core.Services
{
    public class PartService : IPartService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly CarPartsContext _context;

        public PartService(IMapper mapper, IUnitOfWork unitOfWork, CarPartsContext context)
        {
            _mapper=mapper;
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public async Task<PartDto> CreateAsync(PartDto partDto)
        {
           var entity = _mapper.Map<Part>(partDto);
            await _unitOfWork.Parts
                .AddAsync(entity);
            await _unitOfWork.CommitAsync();

            var mappedPart = _mapper.Map<PartDto>(entity);
            return mappedPart;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _unitOfWork.Parts.GetByIdAsync(id);
            if (entity == null)
                throw new ArgumentException("Part not found");

            await _unitOfWork.Parts.DeleteAsync(entity.Id);
            await _unitOfWork.CommitAsync();
        }


        // public  List<PartsQueryModel> GetAllAsync()
        //int pageNumber,int itemPerPage, PartSorting sorting = PartSorting.DateCreated
        public async Task<PartsQueryModel> GetAllAsync(PartsQueryModel queryModel)
        {
            IQueryable<Part> partQuery = _context
                .Parts
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.Category))
            {
                partQuery = partQuery.Where(p => p.Category == queryModel.Category);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.SearchParams))
            {
                string wildCard = $"%{queryModel.SearchParams.ToLower()}%";

                partQuery = partQuery
                    .Where(p => EF.Functions.Like(p.PartName, wildCard) ||
                               EF.Functions.Like(p.PartBrand, wildCard) ||
                               EF.Functions.Like(p.PartDescription, wildCard));

            }


            partQuery = queryModel.PartSorting switch
            {
                PartSorting.DateCreated => partQuery
                .OrderByDescending(p=>p.CreatedOn),
                PartSorting.Year => partQuery
                .OrderBy(y=>y.VehicleModel.Year),
                PartSorting.MakeAndModel =>partQuery
                .OrderBy(m=>m.VehicleMake.MakeName)
                .OrderBy(mo=>mo.VehicleModel.ModelName),
                PartSorting.PriceAscending =>partQuery
                .OrderBy(p=>p.Price),
                PartSorting.PriceDescending =>partQuery
                .OrderByDescending(p=>p.Price)
            };

            IEnumerable<AllPartsDto> allParts = await partQuery
                .Skip((queryModel.CurrentPage-1) * queryModel.PartsPerPage)
                .Take(queryModel.PartsPerPage)
                .Select(p=> new AllPartsDto
                {
                    Id = p.Id,
                    PartName = p.PartName,
                    PartNumber = p.PartNumber,
                    PartDescription = p.PartDescription,
                    CoverImage  = p.CoverImage,
                    Images = p.Images,
                    Category = p.Category,
                    Material = p.Material,
                    Size = p.Size,
                    Condition = p.Condition,
                    PartBrand =  p.PartBrand,
                    Price = p.Price,
                })
                .ToArrayAsync();

            int totalParts = partQuery.Count();

            return new AllPartsFilteredAndPagedServiceModel()
            {
                TotalPartsCount = totalParts,
                Parts = allParts
            };

            //return _context.Parts
            //    .Select(p => new PartDto
            //{
            //    PartName = p.PartName,
            //    PartNumber= p.PartNumber,
            //    PartDescription = p.PartDescription,
            //    PartBrand = p.PartBrand,
            //    CoverImage=p.CoverImage,
            //    Images = p.Images,
            //    Category = p.Category,
            //    Material = p.Material,
            //    Size = p.Size,
            //    Condition = p.Condition,
            //    VehicleMake = vhMake,
            //    VehicleModel = p.VehicleModel.ModelName,
            //    Price = p.Price
            //    }).ToList();
            //var entities = await _unitOfWork.Parts.GetAllAsync();
            //var parts = await _context.Parts.ProjectTo<PartDto>(_mapper.ConfigurationProvider).ToListAsync();
            //var mapDto = _mapper.Map<PartDto, Part>(entities);
            //return mapDto.ToListAsync();
            //return parts;
            return 34;
        }

        public async Task<PartDto> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.Parts.GetByIdAsync(id);
            if (entity == null)
                throw new ArgumentException("Part not found");

            var entityMap = _mapper.Map<Part, PartDto>(entity);

            return entityMap;
        }

        public async Task UpdateAsync(int id,PartDto partDto)
        {
            var entity = await _unitOfWork.Parts.GetByIdAsync(id);
            if(entity == null)
            throw new ArgumentException("Part not found");

            var entityMap = _mapper.Map<PartDto,Part>(partDto);
            await _unitOfWork.Parts.UpdateAsync(entity.Id, entityMap);
            await _unitOfWork.CommitAsync();
        }
    }
}
