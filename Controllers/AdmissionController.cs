using Microservice1.Modals;
using Microservice1.Modals.controllers;
using Microsoft.AspNetCore.Mvc;

namespace Microservice1.Controllers
{
    [Route("api/[Controller]/[action]")]
    [ApiController]
    public class AdmissionController : Controller
    {
        public AdmissionController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        Admission  _AdmissionFunctions = new Admission();

        [HttpGet]
        
        public AdmissioModels getdetails(GetAdmission AdmissionDetails)
        {
            AdmissioModels ResponseData = new AdmissioModels();

            try
            {
                ResponseData.message = "";
                ResponseData.isSuccess = false;

                ResponseData = _AdmissionFunctions.GetDetail(AdmissionDetails);
            }
            catch (Exception ex)
            {
                
                ResponseData.isSuccess = false; 
            }

            return ResponseData;
        }


    }
}
