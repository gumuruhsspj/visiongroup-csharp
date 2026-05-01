using csharp_websocket.Handlers; // Sesuaikan namespace-nya

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware Websocket
app.UseWebSockets();

// Langsung map ke handler tanpa lewat Controller
app.Map("/ws/chat", ChatWebSocketHandler.HandleChat);

app.Run();