using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EdmxLibrary;
using System.Web;
namespace EdmxLibrary
{
 public class clsCompanyList : DataRepository<jpr_CompanyMaster> 
    {
     public List<spCompanyLists_Result> Getall(int intUserID, int intStatusID = 0, string strClientName = "", string strUserName = "", string strCountyName = "")
     {
         return objJPREntities.spCompanyLists_Result(intUserID, intStatusID, strClientName, strUserName, strCountyName).ToList();
     }
    }
    
}
