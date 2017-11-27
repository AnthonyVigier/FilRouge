using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{
    [DataContract]
    public class Topic
    {
        //Properties
        [DataMember]
        public int IdTopic { set; get; }

        [DataMember]
        public string  Title { set; get; }

        [DataMember]
        public string Description { set; get; }

        [DataMember]
        public DateTime DateCreation { set; get; }

        [DataMember]
        public string Auteur { set; get; }

        [DataMember]
        public int IdRubric { get; set; }

        [DataMember]
        public int IdAuthor { get; set; }


        //CTORS
        //Full ctor
        public Topic(int idtopic, int idrubric, string title, string auteur, string description, DateTime datecreation)
        {
            this.IdTopic = idtopic;
            this.Title = title;
            this.Description = description;
            this.DateCreation = datecreation;
            this.IdRubric = idrubric;
            this.Auteur = auteur;
            
        }

        //Default ctor
        public Topic() {}

        //ctor without ID
        public Topic(string title, string description, int author, DateTime datecreation, int idrubric)
        {
            this.Title = title;
            this.Description = description;
            this.IdAuthor = author;
            this.DateCreation = datecreation;
            this.IdRubric = idrubric;

        }

        public Topic(int idtopic)
        {
            this.IdTopic = idtopic;
        }



        //Redefined methods
        public override string ToString()
        {
            return "Id_Topic : " + IdTopic +
                   "Titre : " + Title +
                   "Description : " + Description +
                   "Auteur : " + Auteur +
                   "Date de Création :" + DateCreation;      
        }
    }
}
