using MrCasting.Domain.Entities;

namespace MrCasting.Domain.Interfaces.Application
{
    public interface IInteresseAppService: IAppServiceBase<Interesse>
    {
        void CadastrarInteresse(Interesse interesse);
        void EditarInteresse(int IdCandidato,Interesse interesse);
    }
}
