using AutoMapper;
using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Core.Interfaces;
using CarParts.API.Core.ViewModels;
using CarParts.API.Infrastructure.Data;
using CarParts.API.Infrastructure.Data.Repository;

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
            await _unitOfWork.Parts.AddAsync(entity);
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

        public  List<PartDto> GetAllAsync()
        {
            return _context.Parts.Select(p => new PartDto
            {
                PartName = p.PartName,
                PartNumber= p.PartNumber,
                PartDescription = p.PartDescription,
                PartBrand = p.PartBrand,
                //PartTypeId = p.PartTypeId,
                //PartTypes = p.PartTypes
            }).ToList();
            //var entities = await _unitOfWork.Parts.GetAllAsync();
            //var parts = await _context.Parts.ProjectTo<PartDto>(_mapper.ConfigurationProvider).ToListAsync();
            //var mapDto = _mapper.Map<PartDto, Part>(entities);
            //return mapDto.ToListAsync();
            //return parts;
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
