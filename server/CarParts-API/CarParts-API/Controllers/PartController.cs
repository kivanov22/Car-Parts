using AutoMapper;
using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Core.ViewModels.Parts;
using CarParts.API.Infrastructure.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarParts_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private readonly IMapper _mapper;
        //private readonly IPartService _partService;
        private readonly IUnitOfWork _unitOfWork;

        //public static List<PartDto> parts = new List<PartDto>()
        //{
        //    new PartDto()
        //    {
        //        PartName = "Transmission",
        //        PartNumber = 123123,
        //        PartDescription = "asdasda",
        //        PartBrand = "Bosch",
        //        //PartTypeId = 3,
        //    },
        //    new PartDto()
        //    {
        //        PartName = "Engine",
        //        PartNumber = 123123,
        //        PartDescription = "asdasda",
        //        PartBrand = "Bosch",
        //        //PartTypeId = 3,
        //    },
        //    new PartDto()
        //    {
        //        PartName = "Suspension",
        //        PartNumber = 123123,
        //        PartDescription = "asdasda",
        //        PartBrand = "Bosch",
        //        //PartTypeId = 3,
        //    }
        //};

        public PartController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllParts()
        {
            var parts = await _unitOfWork.Parts.GetAllAsync();
            //var mappedDtos =_mapper.Map<IEnumerable<Part>, PartDto>(parts);


            return Ok(parts.Select(p=>_mapper.Map<PartsQueryModel>(p)));
        }

        //[HttpGet]
        //public ActionResult<List<AllPartsDto>> GetAllParts()//fix make it async
        //{
        //    var parts = _unitOfWork.Parts.GetAllAsync();

        //    return Ok(parts.Select(part=>_mapper.Map<AllPartsDto>(part)));
        //}


        [HttpPost]
        public async Task<JsonResult> Create(PartDto part)
        {
            var partMap = _mapper.Map<Part>(part);
            var createdPart = await _unitOfWork.Parts.AddAsync(partMap);
            await _unitOfWork.CommitAsync();

            //return new JsonResult(Ok(part));
            return new JsonResult(Ok(_mapper.Map<PartDto>(createdPart)));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<JsonResult> Delete([FromRoute] int id)
        {
            var result = await _unitOfWork.Parts.GetByIdAsync(id);

            if (result == null)
                return new JsonResult(NotFound());

           await _unitOfWork.Parts.DeleteAsync(result.Id);
            await _unitOfWork.CommitAsync();

            return new JsonResult(NoContent());
        }

        [HttpGet("{id}")]
        public async Task<JsonResult> GetOnePart(int id)
        {
            var result = await _unitOfWork.Parts.GetByIdAsync(id);

            if (result == null)
                return new JsonResult(NotFound());

            var mapPart = _mapper.Map<Part, PartDto>(result);

            return new JsonResult(Ok(mapPart));
        }


        //edit
        //details
        //search
    }
}
