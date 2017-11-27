using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public int IdResponse { set; get; }

        [DataMember]
        public int IdTopic { set; get; }

        [DataMember]
        public string ResponseTxt { set; get; }

        [DataMember]
        public string Author { set; get; }

        [DataMember]
        public DateTime DateCreation { set; get; }

        [DataMember]
        public int IdAuthor { get; set; }

        //Ctors
        //full constructor
        public Response(int idresponse, int idtopic, string responsetxt, string author, DateTime datecreation)
        {
            this.IdResponse = idresponse;
            this.IdTopic = idtopic;
            this.ResponseTxt = responsetxt;
            this.Author = author;
            this.DateCreation = datecreation;
        }

        public Response(int idtopic, string responsetxt, int idauthor, DateTime datecreation)
        {
            this.IdTopic = idtopic;
            this.ResponseTxt = responsetxt;
            this.IdAuthor = idauthor;
            this.DateCreation = datecreation;
        }

        //default ctor
        public Response() { }

        //Redefined methods
        public override string ToString()
        {
            return "Id_Réponse : " + IdResponse +
                   "Texte : " + ResponseTxt +
                   "Auteur : "+ Author +
                   "Date de poste : " + DateCreation;
        }
    }
}
