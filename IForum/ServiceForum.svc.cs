using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LibraryForum;

namespace IForum
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IForum
    {
     

        public List<Response> GetResponse()
        {
            ResponseDAO resDAO = new ResponseDAO();
            List<Response> listResponsesDAO = new List<Response>();

            listResponsesDAO = resDAO.FindAllResponses();

            return listResponsesDAO;
        }

        public List<Rubric> GetRubrics()
        {
            RubricDAO rDAO = new RubricDAO();
            List<Rubric> listRubricDAO = new List<Rubric>();

            listRubricDAO = rDAO.FindAllRubrics();

            return listRubricDAO;
        }

        public List<Topic> GetTopics()
        {
            TopicDAO tDAO = new TopicDAO();
            List<Topic> listTopicsDAO = new List<Topic>();

            listTopicsDAO = tDAO.FindAllTopics();

            return listTopicsDAO;
        }

        public List<UserForum> GetUsers()
        {
            UserDAO uDAO = new UserDAO();
            List<UserForum> listUsersDAO = new List<UserForum>();

            listUsersDAO = uDAO.GetAllUser();

            return listUsersDAO;
        }
    }

}
