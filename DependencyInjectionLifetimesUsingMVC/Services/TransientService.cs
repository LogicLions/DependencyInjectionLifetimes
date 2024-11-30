using DependencyInjectionLifetimesUsingMVC.Services.Interfaces;

namespace DependencyInjectionLifetimesUsingMVC.Services
{
    public class TransientService : ITransient
    {
        private readonly Guid Id;

        public TransientService() 
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
