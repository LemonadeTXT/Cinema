namespace Cinema.Common.Response
{
    public record UserResponse(
        Guid Id,
        string Email,
        string PasswordHash);
}
