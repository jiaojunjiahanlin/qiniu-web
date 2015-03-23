using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebApplication1.IO
{
    public class Policy
    {
        private string scope = "";

        public string Scope
        {
            get { return scope; }
            set { scope = value; }
        }
        private Int64 deadline = 0;

        public Int64 Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        private int insertOnly = 0;

        public int InsertOnly
        {
            get { return insertOnly; }
            set { insertOnly = value; }
        }
        private string saveKey = "";

        public string SaveKey
        {
            get { return saveKey; }
            set { saveKey = value; }
        }
        private string endUser = "";

        public string EndUser
        {
            get { return endUser; }
            set { endUser = value; }
        }
        private string returnUrl = "";

        public string ReturnUrl
        {
            get { return returnUrl; }
            set { returnUrl = value; }
        }
        private string returnBody = "";

        public string ReturnBody
        {
            get { return returnBody; }
            set { returnBody = value; }
        }
        private string callbackUrl = "";

        public string CallbackUrl
        {
            get { return callbackUrl; }
            set { callbackUrl = value; }
        }
        private string callbackBody = "";

        public string CallbackBody
        {
            get { return callbackBody; }
            set { callbackBody = value; }
        }
        private string persistentOps = "";

        public string PersistentOps
        {
            get { return persistentOps; }
            set { persistentOps = value; }
        }
        private string persistentNotifyUrl = "";

        public string PersistentNotifyUrl
        {
            get { return persistentNotifyUrl; }
            set { persistentNotifyUrl = value; }
        }
        private string persistentPipeline = "";

        public string PersistentPipeline
        {
            get { return persistentPipeline; }
            set { persistentPipeline = value; }
        }
        private string mimeLimit = "";

        public string MimeLimit
        {
            get { return mimeLimit; }
            set { mimeLimit = value; }
        }
        private int detectMime = 0;

        public int DetectMime
        {
            get { return detectMime; }
            set { detectMime = value; }
        }
        private Int64 fsizeLimit = 0;

        public Int64 FsizeLimit
        {
            get { return fsizeLimit; }
            set { fsizeLimit = value; }
        }
        private UInt32 expires = 0;

        public UInt32 Expires
        {
            get { return expires; }
            set { expires = value; }
        }

        private UInt32 callbackFetchKey = 0;

        public UInt32 CallbackFetchKey
        {
            get { return callbackFetchKey; }
            set { callbackFetchKey = value; }
        }
        private string callbackBodyType = "";

        public string CallbackBodyType
        {
            get { return callbackBodyType; }
            set { callbackBodyType = value; }
        }
        public Policy(string scope, UInt32 exp = 3600)
		{
			Scope = scope;
            this.Expires = exp;
            this.deadline = (UInt32)((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000)/10000000 + (long)exp);
           
		}
      
        public  override string ToString()
{
 	         return setting.setjson(this);
}

     
    }
}