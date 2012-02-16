using System;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service : IService
    {
        public void Add(Company company)
        {
            if (company == null)
            {
                throw new ArgumentNullException("company");
            }
        }
    }
}