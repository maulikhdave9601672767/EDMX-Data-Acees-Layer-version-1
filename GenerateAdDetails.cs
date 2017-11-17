using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdmxLibrary
{
    public class GenerateAdDetails : DataRepository<jpr_AdMaster> 
    {
        public List<spGetGenerateAdDetails_Result> Getall(int intCompanyID)
        {
            return objJPREntities.spGetGenerateAdDetails(intCompanyID).ToList();
        }
    }
}
