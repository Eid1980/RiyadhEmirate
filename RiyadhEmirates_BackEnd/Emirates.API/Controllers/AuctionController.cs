using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Auctions;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : BaseController, IAuctionService
    {
        private readonly IAuctionService _auctionService;
        public AuctionController(ILocalizationService localizationService,
            IAuctionService auctionService) : base(localizationService)
        {
            _auctionService = auctionService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _auctionService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _auctionService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _auctionService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateAuctionDto createDto)
        {
            return _auctionService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateAuctionDto updateDto)
        {
            return _auctionService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _auctionService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _auctionService.Delete(id);
        }

    }
}
