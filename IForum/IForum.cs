using LibraryForum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IForum
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IForum
    {
        [OperationContract]
        [WebGet(UriTemplate = "Rubric")]
        List<Rubric> GetRubrics();

        [OperationContract]
        [WebGet(UriTemplate = "Topic")]
        List<Topic> GetTopics();

        [OperationContract]
        [WebGet(UriTemplate = "Response")]
        List<Response> GetResponse();

        [OperationContract]
        [WebGet(UriTemplate = "UserForum")]
        List<UserForum> GetUsers();
    }


  
}
