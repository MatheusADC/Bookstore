using Microsoft.AspNetCore.Mvc;
using LivrariaApi.Communication.Requests;
using LivrariaApi.Communication.Responses;


namespace LivrariaApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]

    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisteredBookJson
        {
            Id = request.Id,
            Title = request.Title
        };

        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("{id}/title/{title}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

    public IActionResult GetById([FromRoute] int id, [FromRoute] string title)
    {
        var response = new Book
        {
            Id = 1,
            Title = "Buddenbrooks",
            Author = "Thomas Mann",
            Genre = "Drama",
            Price = 24.95,
            Stock = 10
        };

        return Ok(response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult Update([FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult Delete()
    {
        return NoContent();
    }
}
