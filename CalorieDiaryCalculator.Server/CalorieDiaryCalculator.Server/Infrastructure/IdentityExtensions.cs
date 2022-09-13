﻿using System.Security.Claims;

namespace CalorieDiaryCalculator.Server.Infrastructure {
    public static class IdentityExtensions {
        public static string GetId(this ClaimsPrincipal user) =>
            user.Claims
            .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?
            .Value;
    }
}
