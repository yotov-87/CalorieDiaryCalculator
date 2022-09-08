using CalorieDiaryCalculator.Server.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CalorieDiaryCalculator.Server.Data {
    public class CalorieDiaryCalculatorDbContext : IdentityDbContext<User> {
        public CalorieDiaryCalculatorDbContext(DbContextOptions<CalorieDiaryCalculatorDbContext> options)
            : base(options) {
        }
    }
}