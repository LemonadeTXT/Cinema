namespace Cinema.Common.Request
{
    public record UserRequest(
        string Email,
        string PasswordHash);
}
