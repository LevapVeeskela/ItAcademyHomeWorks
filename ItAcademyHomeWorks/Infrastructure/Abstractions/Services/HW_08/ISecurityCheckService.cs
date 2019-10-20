using Common.Models;

namespace Infrastructure.Abstractions.Services.HW_08
{
    public interface ISecurityCheckService
    {
        bool CheckCarryon(PersonModel person);

        bool CheckPerson(PersonModel person);
    }
}
