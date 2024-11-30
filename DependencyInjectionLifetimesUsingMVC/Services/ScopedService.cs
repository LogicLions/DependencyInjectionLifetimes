using DependencyInjectionLifetimesUsingMVC.Services.Interfaces;

namespace DependencyInjectionLifetimesUsingMVC.Services
{
    public class ScopedService : IScoped
    {
        private readonly Guid Id;

        public ScopedService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
