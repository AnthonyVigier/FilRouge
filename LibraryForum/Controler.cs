using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForum
{

    //Cette classe permet à l'ihm d'être découplée des classes DAO
    public class Controler
    {
        //Rubrics
        public List<Rubric> FindAllRubrics()
        {
            return RubricDAO.GetInstance().FindAllRubrics();
        }

        public List<Rubric> GetIdRubric(string namerubric)
        {
            return RubricDAO.GetInstance().GetIdRubric(namerubric);
        }

        //Users
        public bool UserConnection(string pseudo, string userpass)
        {
            return UserDAO.GetInstance().UserConnection(pseudo, userpass);
        }

        public bool UserIsModerator(string pseudo, string userpass)
        {
            return UserDAO.GetInstance().UserIsModerator(pseudo, userpass);
        }

        public List<UserForum> GetIdUser(string pseudo)
        {
            return UserDAO.GetInstance().GetIdUser(pseudo);
        }

        public List<UserForum> GetAllUsers()
        {
            return UserDAO.GetInstance().GetAllUser();
        }

        public void UpdatePassword(UserForum userForum)
        {
            UserDAO.GetInstance().UpdatePassword(userForum);
        }

        //Responses
        public List<Response> FindResponsesByTopic(int idtopic)
        {
            return ResponseDAO.GetInstance().FindResponsesByTopic(idtopic);
        }

        public List<Response> FindAllResponses()
        {
            return ResponseDAO.GetInstance().FindAllResponses();
        }

        public void AddResponse(Response response)
        {
            ResponseDAO.GetInstance().AddResponse(response);
        }

        public void DeleteResponse(int idResponse)
        {
            ResponseDAO.GetInstance().DeleteResponse(idResponse);
        }

        public void DeleteResponseByIdTopic(int idtopic)
        {
            ResponseDAO.GetInstance().DeleteResponseByIdTopic(idtopic);
        }

        public void UpdateResponse(Response response)
        {
            ResponseDAO.GetInstance().UpdateResponse(response);
        }

        //Topics
        public List<Topic> FindTopicOne()
        {
            return TopicDAO.GetInstance().FindTopicOne();
        }

        public List<Topic> FindTopicsByRubrics(string nameRubric)
        {
            return TopicDAO.GetInstance().FindTopicsByRubrics(nameRubric);
        }

        public List<Topic> GetIdTopic(int idtopic)
        {
            return TopicDAO.GetInstance().GetIdTopic(idtopic);
        }

        public DataTable GetIdTopicByTitleTopic(string nametopic)
        {
            return TopicDAO.GetInstance().GetIdTopicByTitleTopic(nametopic);
        }

        public List<Topic> FindAllTopics()
        {
            return TopicDAO.GetInstance().FindAllTopics();
        }

        public void AddTopic(Topic topic)
        {
            TopicDAO.GetInstance().AddTopic(topic);
        }

        public void  DeleteTopic(int idtopic)
        {
            TopicDAO.GetInstance().DeleteTopic(idtopic);
        }

        public void UpdateTopic(Topic topic)
        {
            TopicDAO.GetInstance().UpdateTopic(topic);
        }
    }
}
