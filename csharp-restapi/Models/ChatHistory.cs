namespace csharp_restapi.Models;

public record ChatHistory(
    Guid? Id, 
    string User, 
    string Message, 
    DateTime? Timestamp
);