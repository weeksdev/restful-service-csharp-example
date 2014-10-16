using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using WeeksDev;
/// <summary>
/// Summary description for RestService
/// </summary>
[ServiceContract]
[AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Allowed)]
[ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
public class RestService
{
	public RestService()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public enum Gender{
        Male,
        Female
    }
    public class Account
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string accountNumber { get; set; }
        public Gender gender { get; set; }
    }

    [WebInvoke(Method="GET", UriTemplate="Account/{id}")]
    public void GetAccount(string id)
    {
        try
        {
            var account = new Account() { firstName = "Andrew", lastName = "Weeks", accountNumber = id, gender = Gender.Male };
            account.WriteJsonResponse();
        }
        catch (Exception ex)
        {
            ex.WriteJsonResponse(ex.Message, "", false);
        }
    }

    [WebInvoke(Method="POST", UriTemplate="UpdateAccount")]
    public void UpdateAccount(Account account)
    {
        //save account to database
        WeeksDev.ResponseHelpers.WriteJsonResponse(null, "", "", true);
    }

    [WebInvoke(Method = "PUT", UriTemplate = "CreateAccount")]
    public void CreateAccount(Account account)
    {
        WeeksDev.ResponseHelpers.WriteJsonResponse(null, "", "", true);
    }

    [WebInvoke(Method = "DELETE", UriTemplate = "DeleteAccount")]
    public void DeleteAccount(Account account)
    {
        WeeksDev.ResponseHelpers.WriteJsonResponse(null, "", "", true);
    }
}