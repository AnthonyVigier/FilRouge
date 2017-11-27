using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{

    [DataContract]
    public class Rubric
    {

        //Properties

        [DataMember]
        public int IdRubric { set; get; }

        [DataMember]
        public string Name { set; get; }

        [DataMember]
        public string Description { set; get; }

        //Ctors
        //full constructor
        public Rubric(int idrubric, string name, string description)
        {
            this.IdRubric = idrubric;
            this.Name = name;
            this.Description = description;
        }

        //default ctor
        public Rubric() { }


        public Rubric(int idrubric)
        {
            this.IdRubric = idrubric;
        }


        //Redefined methods
        public override string ToString()
        {
            return Name;
                   
        }
    }
}
