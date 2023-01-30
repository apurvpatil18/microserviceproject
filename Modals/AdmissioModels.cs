using Microsoft.AspNetCore.Mvc;

namespace Microservice1.Modals
{
    public class AdmissioModels : CommonResponse
    {
        //public string MobileNo { get; set; }
        public string FirstName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }

    }
    public class GetAdmission 
    { 
        public string AdmissionId { get; set; }
    }
    public class CommonResponse
    {
        public bool isSuccess { get; set; }
        public string message { get; set; } 
    }
    public class ProductModels : CommonResponse
    {
        public string ProductId { get; set; } 
        public string ProductName  { get; set; } 
        public string Description  { get; set; } 
    
    }
}
