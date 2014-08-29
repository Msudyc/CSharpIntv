/* Question 8.2
 
Image you have a call center with three levels of employees: respondent, manager, and director.
An incoming telephone call must be first allocated to a respondent who is free. If the respondent
cannot handle the call, he or she must escalate the call to a manager. If the manager is not free
or not able to handle it, then the call should be escalated to a director. Design the classes 
and data structures for this problem. Implement a method dispatchCall() which assigns a call to 
the first available employee.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q02
    {
        public enum Rank
        {
            Respondent = 0,
            Manager = 1,
            Director = 2
        }

        public class CallHandler
        {
            private static CallHandler instance;

            private const int Levels = 3;
            private const int NumOfRespondents = 10;
            private const int NumOfManagers = 4;
            private const int NumOfDirectors = 2;

            private List<List<Employee>> employeeLevels = new List<List<Employee>>();
            private List<List<Call>> callQueues = new List<List<Call>>();

            protected CallHandler()
            {
            }

            public static CallHandler GetInstance()
            {
                if (instance == null)
                {
                    instance = new CallHandler();
                }

                return instance;
            }

            public Employee GetHandlerForCall(Call call)
            {
                throw new NotImplementedException();
            }

            public void DispatchCall(Caller caller)
            {
                Call call = new Call(caller);
                this.DispatchCall(call);
            }

            public void DispatchCall(Call call)
            {
                Employee e = this.GetHandlerForCall(call);
                if (e != null)
                {
                    e.ReceiveCall(call);
                    call.SetHandler(e);
                }
                else
                {
                    call.Reply("Please wait for free employee to reploy");
                    callQueues[(int)call.GetRank()].Add(call);
                }
            }

            public bool AssignCall(Employee e)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class Employee
        {
            private Call currentCall;
            protected Rank rank;

            public void ReceiveCall(Call call)
            {
                this.currentCall = call;
            }

            public void CallCompleted()
            {
            }

            public void EscalateAndReasign()
            {
            }

            public bool IsFree()
            {
                return currentCall == null;
            }

            public Rank GetRank()
            {
                return this.rank;
            }
        }

        public class Director : Employee
        {
            public Director()
            {
                this.rank = Rank.Director;
            }
        }

        public class Manager : Employee
        {
            public Manager()
            {
                this.rank = Rank.Manager;
            }
        }

        public class Respondent : Employee
        {
            public Respondent()
            {
                this.rank = Rank.Respondent;
            }
        }

        public class Call
        {
            private Rank rank;
            private Caller caller;
            private Employee handler;

            public Call(Caller c)
            {
                this.rank = Rank.Respondent;
                this.caller = c;
            }

            public void SetHandler(Employee e)
            {
                this.handler = e;
                this.rank = e.GetRank();
            }

            public void Reply(string message)
            {
            }

            public Rank GetRank()
            {
                return this.rank;
            }

            public void SetRank(Rank rank)
            {
                this.rank = rank;
            }

            public Rank IncrementRank()
            {
                throw new NotImplementedException();
            }

            public void Disconnect()
            {
            }
        }

        public class Caller
        {
        }
    }
}
