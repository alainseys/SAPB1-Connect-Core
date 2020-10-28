using System;
using System.Configuration;

namespace NetCoreSAPB1_Connect
{
    public class ServerConnection
    {
        private SAPbobsCOM.Company company = new SAPbobsCOM.Company();
        private int connectionResult;
        private int errorCode = 0;
        private string errorMessage = "";

        public int Connect() 
        {
            company.Server = ConfigurationManager.AppSettings["server"].ToString();
            company.CompanyDB = ConfigurationManager.AppSettings["companydb"].ToString();
            company.DbUserName = ConfigurationManager.AppSettings["dbuser"].ToString();
            company.DbPassword = ConfigurationManager.AppSettings["dbpass"].ToString();
            company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012;
            company.UserName = ConfigurationManager.AppSettings["user"].ToString();
            company.Password = ConfigurationManager.AppSettings["pass"].ToString();
            company.language = SAPbobsCOM.BoSuppLangs.ln_Dutch;
            company.UseTrusted = false;
            company.LicenseServer = ConfigurationManager.AppSettings["licenseServer"].ToString();
            connectionResult = company.Connect();
            if(connectionResult != 0) 
            {
                company.GetLastError(out errorCode, out errorMessage);
            }
            return connectionResult;
        }
        public SAPbobsCOM.Company GetCompany()
        {
            return this.company;
        }
        public int GetErrorCode()
        {
            return this.errorCode;
        }
        public String GetErrorMessage()
        {
            return this.errorMessage;
        }

    }
}
