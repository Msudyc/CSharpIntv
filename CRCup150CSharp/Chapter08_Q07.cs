/* Question 8.7
 
Explain how you would design a chat server. In particular, provide details about the various 
backend components, classes, and methods. What would be the hardest problems to solve? 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q07
    {
        public class UserManager
        {
            private static UserManager instance;
            private Dictionary<int, User> users = new Dictionary<int, User>();

            public static UserManager GetInstance()
            {
                if (instance == null)
                    instance = new UserManager();
                return instance;
            }

            public void AddUser(User user)
            {
            }

            public void ApproveAddRequest(AddRequest req)
            {
            }

            public void RejectAddRequest(AddRequest req)
            {
            }

            public void UserSignOn(string accountName)
            {
            }

            public void UserSignOff(string accountName)
            {
            }
        }

        public class User
        {
            public string Name { get; set; }
            private Dictionary<int, PrivateChat> privateChats = new Dictionary<int, PrivateChat>();
            private List<GroupChat> groupChats = new List<GroupChat>();

            public bool SendMessageToUser(User user, string content)
            {
                throw new NotImplementedException();
            }

            public bool SendMessageToGroupChat(int id, string content)
            {
                throw new NotImplementedException();
            }

            public void SendAddRequest(AddRequest req)
            {
            }

            public void RemoveAddRequest(AddRequest req)
            {
            }

            public void ReceiveAddRequest(AddRequest req)
            {
            }

            public void AddConversation(PrivateChat chat)
            {
            }

            public void AddConversation(GroupChat chat)
            {
            }
        }

        public class Conversation
        {
            public int ID { get; set; }

            protected List<User> participants = new List<User>();
            protected List<Message> messages = new List<Message>();
        }

        public class GroupChat : Conversation
        {
            public void AddParticipant(User user)
            {
            }

            public void RemoveParticipant(User user)
            {
            }
        }

        public class PrivateChat : Conversation
        {
            public PrivateChat(User user1, User user2)
            {
            }
        }

        public class Message
        {
            public string Content { get; set; }
            public DateTime Date { get; set; }
        }

        public class AddRequest
        {
            public User FromUser { get; set; }
            public User ToUser { get; set; }
            public DateTime Date { get; set; }
            public RequestStatusType Status { get; set; }
        }

        public class UserStatus
        {
            public string Message { get; set; }
            public UserStatusType Type { get; set; }
        }

        public enum UserStatusType
        {
            Offline,
            Away,
            Idle,
            Available,
            Busy
        }

        public enum RequestStatusType
        {
            Unread,
            Read,
            Accepted,
            Rejected
        }
    }
}
