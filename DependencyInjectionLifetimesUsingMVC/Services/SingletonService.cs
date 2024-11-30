using DependencyInjectionLifetimesUsingMVC.Services.Interfaces;

namespace DependencyInjectionLifetimesUsingMVC.Services
{
    public class SingletonService : ISingleton
    {
        private readonly Guid Id;

        public SingletonService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
