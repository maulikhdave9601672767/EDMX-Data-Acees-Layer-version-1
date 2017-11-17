using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EdmxLibrary;
/// <summary>
/// Summary description for ClientRegistration
/// </summary>
public class ClientRegistration : DataRepository<jpr_ClientMaster> 
{
	public ClientRegistration()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<GetClientInformation_Result> Getall()
    {
        //return objJPREntities.GetClientInformation("test").ToList();
        return objJPREntities.GetClientInformation().ToList();
    }
}