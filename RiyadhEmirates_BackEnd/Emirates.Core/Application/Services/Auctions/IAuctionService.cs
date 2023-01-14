using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Shared;

namespace Emirates.Core.Application.Services.Auctions
{
    public interface IAuctionService
    {
        IApiResponse GetById(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateAuctionDto createModel);
        IApiResponse Update(UpdateAuctionDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
    }
}
