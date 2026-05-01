using System.Net.WebSockets;
using System.Text;

namespace csharp_websocket.Handlers;

public static class ChatWebSocketHandler
{
    public static async Task HandleChat(HttpContext context)
    {
        if (context.WebSockets.IsWebSocketRequest)
        {
            using var webSocket = await context.WebSockets.AcceptWebSocketAsync();
            var buffer = new byte[1024 * 4];

            while (webSocket.State == WebSocketState.Open)
            {
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Close) break;

                var userMsg = Encoding.UTF8.GetString(buffer, 0, result.Count);
                var botResponse = $"[AI Bot] Response for: {userMsg}";
                var responseData = Encoding.UTF8.GetBytes(botResponse);

                await webSocket.SendAsync(new ArraySegment<byte>(responseData), WebSocketMessageType.Text, true, CancellationToken.None);
            }
            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed", CancellationToken.None);
        }
        else
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
    }
}