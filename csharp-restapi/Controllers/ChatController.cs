using csharp_restapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_restapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private static readonly List<ChatHistory> _db = new();

    [HttpGet]
    public IActionResult GetHistory() => Ok(_db);

    [HttpPost]
    public IActionResult SaveChat([FromBody] ChatHistory chat)
    {
        var newChat = chat with { Id = Guid.NewGuid(), Timestamp = DateTime.Now };
        _db.Add(newChat);
        return CreatedAtAction(nameof(GetHistory), newChat);
    }
}