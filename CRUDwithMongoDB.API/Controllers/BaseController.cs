using CRUDwithMongoDB.BL.Services;
using CRUDwithMongoDB.Common.Models;
using Microsoft.AspNetCore.Mvc;
using SharpCompress.Common;

namespace CRUDwithMongoDB.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController<T> : ControllerBase
    where T : BaseModel
{
    private readonly BaseService<T> _service;

    public BaseController(BaseService<T> service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult> Get() => Ok(await _service.GetAsync());

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult> Get(string id)
    {
        var item = await _service.GetAsync(id);

        if (item is null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult> Post(T entity)
    {
        await _service.InsertAsync(entity);

        return CreatedAtAction(nameof(Get), new { entity.Id }, entity);
    }

    [HttpPut]
    public async Task<ActionResult> Update(T entity)
    {
        var item = await _service.GetAsync(entity.Id);

        if (item is null)
        {
            return NotFound();
        }

        await _service.UpdateAsync(entity);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<ActionResult> Delete(string id)
    {
        var item = await _service.GetAsync(id);

        if (item is null)
        {
            return NotFound();
        }
        try
        {

        await _service.DeleteAsync(id);
        }
        catch (Exception ex)
        {

        }

        return NoContent();
    }
}
