

using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Dtos;

namespace VeterinaryApi.Controllers;

public class CitationController : BaseApiController 
{
    private readonly IUnityOfWork _unityOfWork;
    private readonly IMapper _mapper;

    public CitationController(IUnityOfWork unityOfWork,IMapper mapper)
    {
        _unityOfWork = unityOfWork;
        _mapper = mapper;
    }
    /* [MapToApiVersion("1.0")] /* 
    [Authorize(Roles = "Administrator, Employee")] */
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CitationDto>>> Get()
    {
        var citations = await _unityOfWork.Citations.GetAllAsync();
        return _mapper.Map<List<CitationDto>>(citations);
    }
}
