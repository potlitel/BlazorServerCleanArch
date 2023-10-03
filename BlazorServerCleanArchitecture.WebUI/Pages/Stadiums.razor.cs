using BlazorServerCleanArchitecture.Application.Features.Stadiums.Queries.GetAllStadiums;

namespace BlazorServerCleanArchitecture.WebUI.Pages
{
    public partial class Stadiums
    {
        private List<GetAllStadiumsDto>? stadiums;

        protected override async Task OnInitializedAsync()
        {
            stadiums = await Mediator.Send(new GetAllStadiumsQuery());
        }
    }
}