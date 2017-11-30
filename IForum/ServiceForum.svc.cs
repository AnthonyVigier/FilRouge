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
        private Controler controler = new Controler();

        public List<Response> GetResponse()
        {
            List<Response> listResponsesDAO = new List<Response>();
            listResponsesDAO = controler.FindAllResponses();

            return listResponsesDAO;
        }

        public List<Rubric> GetRubrics()
        {
            List<Rubric> listRubricDAO = new List<Rubric>();
            listRubricDAO = controler.FindAllRubrics();

            return listRubricDAO;
        }

        public List<Topic> GetTopics()
        {
            List<Topic> listTopicsDAO = new List<Topic>();

            listTopicsDAO = controler.FindAllTopics();

            return listTopicsDAO;
        }

        public List<UserForum> GetUsers()
        {
            List<UserForum> listUsersDAO = new List<UserForum>();
            listUsersDAO = controler.GetAllUsers();

            return listUsersDAO;
        }
    }

}
