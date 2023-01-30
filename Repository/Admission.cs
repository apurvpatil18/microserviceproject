using Microservice1.Repository;
using MySql.Data.MySqlClient;
using System.Data;

namespace Microservice1.Modals.controllers
{
    public class Admission : IAdmission
    {
        public AdmissioModels GetDetail(GetAdmission userCreds)
        {
            AdmissioModels AdmissionData = new AdmissioModels();
            DataSet dbData =    new DataSet();

            //try
            //{
            //    using (MySqlConnection conn = Globals.Connection)
            //    {
            //        MySqlParameter[] Param = new MySqlParameter[]
            //        {
            //            new MySqlParameter("@_AdmissionId ", userCreds.AdmissionId)
            //        };

            //        dbData = MySqlHelper.ExecuteDataset(conn, "GetDetails(@_AdmissionId);", Param);

            //        if (dbData.Tables[1].Rows.Count > 0)
            //        {
            //            // AdmissionData.FirstName = dbData.Tables[0].Rows[0]["FirstName"] ;

            //        }
            //    }
            //}
            //catch (Exception Ex)
            //{

            //}

            AdmissionData.message = "success";
            AdmissionData.FirstName = "Prathmesh";
            AdmissionData.EmailId = "Prathmesh@teamlease.com";
            AdmissionData.MobileNo = "1234567890";
            AdmissionData.isSuccess = true;
            return AdmissionData;
        }

        //public ProductModels GetProductList(GetProduct userCreds) 
        //{
        //    ProductModels ProductData = new ProductModels();
        //    return ProductData;


        //}
    }
}
