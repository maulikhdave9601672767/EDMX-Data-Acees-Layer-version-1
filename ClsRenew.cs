using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EdmxLibrary;

namespace EdmxLibrary
{
    public class ClsRenew : DataRepository<jpr_CompanyMaster> 
    {
        public List<SP_RenewList_Result> GetAllRenlist()
        {
            return objJPREntities.SP_RenewList_ResultNew3(Convert.ToDateTime(DateTime.Now.Date)).ToList();
        }

        public List<SP_CheckEmail_Result> GetEmaillist()
        {
            return objJPREntities.SP_CheckEmail_ResultNew(Convert.ToDateTime(DateTime.Now.Date)).ToList();
        }

        public void DeleteCompanyDetails(Int64 ComID)
        {
            objJPREntities.Sp_DeleteCompanyDetail(ComID);
        }
    }
}
