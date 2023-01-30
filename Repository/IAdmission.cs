using Microsoft.AspNetCore.Mvc;

namespace Microservice1.Modals.controllers
{
    public interface IAdmission
    {
        public AdmissioModels GetDetail(GetAdmission userCreds);

    }
    public interface IProduct
    {
        public ProductModels GetProductList(ProductModels userCreds);
    }
}
