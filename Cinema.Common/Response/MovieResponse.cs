using Cinema.Domain.Enums;

namespace Cinema.Common.DTOs
{
    public record MovieResponse(
        Guid Id, 
        string Title, 
        string Description, 
        AgeRating AgeRating, 
        int FreeSeats, 
        DateTime Session);
}
