using AuctionService.Data;
using AuctionService.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuctionsController(IAuctionRepository auctionRepository) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<AuctionDto>>> GetAllAuctions(string date)
    {
        return await auctionRepository.GetAuctionsAsync(date);
    }
}
