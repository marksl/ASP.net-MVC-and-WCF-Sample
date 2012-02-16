using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void Add(Company company);
    }
}