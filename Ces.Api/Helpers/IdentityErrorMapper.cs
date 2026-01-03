using Microsoft.AspNetCore.Identity;

namespace Ces.Api.Helpers
{
    public static class IdentityErrorMapper
    {
        public static Dictionary<string, string[]> Map(IEnumerable<IdentityError> errors)
        {
            return errors
                .GroupBy(e => e.Code)
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(e => e.Description).ToArray()
                );
        }
    }
}
