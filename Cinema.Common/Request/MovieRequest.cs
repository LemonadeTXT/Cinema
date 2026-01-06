using Cinema.Domain.Enums;

namespace Cinema.Common.Request
{
    public record MovieRequest(
        string Title,
        string Description,
        AgeRating AgeRating,
        int FreeSeats,
        DateTime Session);
}
