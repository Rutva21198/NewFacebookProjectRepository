using RxWeb.Core.Data;
using FacebookProjectRxWeb.BoundedContext.Main;

namespace FacebookProjectRxWeb.UnitOfWork.Main
{
    public class MasterUow : BaseUow, IMasterUow
    {
        public MasterUow(IMasterContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IMasterUow : ICoreUnitOfWork { }
}


