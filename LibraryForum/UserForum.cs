using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{
    [DataContract]
    public class UserForum
    {
        //Properties

        [DataMember]
        public int IdUser { set; get; }

        [DataMember]
        public string Pseudo { set; get; }

        [DataMember]
        public string UserPass { set; get; }

        [DataMember]
        public string MailUser { set; get; }

        [DataMember]
        public string UserFunction { set; get; }


        //Ctors
        //Full constructor
        public UserForum(int iduser, string pseudo, string userpass, string usermail, string userfunction)
        {
            this.IdUser = iduser;
            this.Pseudo = pseudo;
            this.UserPass = userpass;
            this.UserFunction = userfunction;
            this.MailUser = usermail;
        }

        public UserForum (int iduser)
        {
            this.IdUser = iduser;
        }


        //Defaut constructor
        public UserForum()
        {
        }

        public override string ToString()
        {
            return IdUser.ToString();
                
        }

    }
}
