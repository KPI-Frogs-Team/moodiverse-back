using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using Moodiverse.Common.Auth;
using Moodiverse.Common.Security;

namespace Moodiverse.BL.JWT;

public class JwtFactory
{
    private readonly JwtIssuerOptions _jwtOptions;
    private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler;

    public JwtFactory(IOptions<JwtIssuerOptions> jwtOptions)
    {
        _jwtOptions = jwtOptions.Value;
        _jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
    }
    
    public async Task<string> GenerateAccessToken(int id, string userName, string email)
    {
        // var identity = GenerateClaimsIdentity(id, userName);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.NameId, id.ToString()),
            new Claim(JwtRegisteredClaimNames.UniqueName, userName),
            new Claim(JwtRegisteredClaimNames.Email, email),
        };

        // Create the JWT security token and encode it.
        var jwt = new JwtSecurityToken(
            _jwtOptions.Issuer,
            _jwtOptions.Audience,
            claims,
            _jwtOptions.NotBefore,
            _jwtOptions.Expiration,
            _jwtOptions.SigningCredentials);

        return _jwtSecurityTokenHandler.WriteToken(jwt);
    }
    
    public string GenerateRefreshToken()
    {
        return Convert.ToBase64String(SecurityHelper.GetRandomBytes());
    }
}