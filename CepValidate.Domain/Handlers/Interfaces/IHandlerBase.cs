using CepValidate.Domain.Commands.Interfaces;

namespace CepValidate.Domain.Handlers.Interfaces
{
    interface IHandlerBase<T> where T : ICommandBase
    {
        ICommandBase Handle(T command);
    }
}