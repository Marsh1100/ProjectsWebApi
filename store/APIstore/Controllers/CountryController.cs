
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIstore.Controllers;

public class CountryController : BaseApiController
{
    private readonly IUnitOfWork unitOfWork;
    public CountryController(IUnitOfWork _unitOfWork)
    {
        this.unitOfWork = _unitOfWork;
    }
    
    //Definicion del nuevo endpoint
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Get()
    {
        var nameVar = await unitOfWork.Countries.GetAllAsync();
        return Ok(nameVar);
    }

    
}


 