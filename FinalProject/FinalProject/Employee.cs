using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject {
    /***EmployeeFactory creates new AbsEmployee using reflection on the position parameter***/
    internal class EmployeeFactory {
        public AbsEmployee Create(string name, double wage, string position, AbsEmployee supervisor) {
            try {
                //strip chars and add namespace
                position = Regex.Replace(position, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
                position = "FinalProject." + position;

                //Reflection to create product
                //Positions come from combobox in Form1, shouldn't need to check that they are correct format
                Type t = Type.GetType(position);
                AbsEmployee e = (AbsEmployee)Activator.CreateInstance(t);

                //Set attributes
                e.Name = name;
                e.Wage = wage;

                //SetHeadPerson returns true if supervisor is a higher position
                if (e.SetHeadPerson(supervisor)){
                    return e;
                }

                //if invalid supervisor, return null
                return null;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }

    /***AbsEmployee class, uses chain of command for getAllHigher and getAllLower***/
    internal abstract class AbsEmployee {
        protected string name = "";
        protected double wage = 0;
        protected AbsEmployee parent;
        protected string position;
        internal List<AbsEmployee> directSubordinates = new();

        //Properties
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public double Wage { get => wage; set => wage = value; }
        public AbsEmployee Parent { get => parent;  }
        public List<AbsEmployee> GetDirectSubordinates() => directSubordinates;

        //Constructors
        public AbsEmployee() { }
        public AbsEmployee(string name, double wage, AbsEmployee parent) {
            this.name = name;
            this.wage = wage;
            this.parent = parent;
        }

        //Each child class will check if the parent is a valid type of supervisor for them
        public abstract bool SetHeadPerson(AbsEmployee parent);

        //Uses chain of command to add everyone higher up in direct line of command structure
        //Would return a shift supervisor's assistant manager and that assistant manager's store manager
        //Would not return other assistant managers or store managers (not in direct line)
        public List<string> GetAllHigher() {
            List<string> str = new();

            if(parent != null) {
                str.AddRange(parent.GetAllHigher());
                str.Add("\n" + parent.position + ": " + parent.name);
            }

            return str;
        }

        //Uses chain of command to add everyone lower in direct line of command structure
        //Would return a shift supervisor's workers
        //Would not return other shift supervisors' workers (not in direct line)
        public List<string> GetAllLower() {
            List<string> str = new();

            if (directSubordinates.Count != 0) {
                foreach (AbsEmployee e in directSubordinates) {
                    str.Add("\n" + e.position + ": " + e.name);
                    str.AddRange(e.GetAllLower());
                }
            }
            return str;
        }

        //Child calls this on their parent to add themselves to parent's subordinates
        public void AssignEmployee(AbsEmployee employee) {
            directSubordinates.Add(employee);
        }
    }

    /***Store manager is at top of hierarchy***/
    //Has merker interface StoreManagerIF, which inherits from ManagerIF which inherits from SupervisorIF (used for composite pattern)
    internal class StoreManager : AbsEmployee, StoreManagerIF {
        public StoreManager() { position = "Store Manager"; }
        public StoreManager(string name, double wage) {
            position = "Store Manager";
            this.name = name;
            this.wage = wage;
        }

        //Store manager cannot have head person, always return false
        public override bool SetHeadPerson(AbsEmployee parent) {
            return false;
        }
    }

    /***AssistantManager is second from top in hierarchy***/
    //Has marker interface ManagerIF, which inherits from SupervisorIF (used for composite pattern)
    internal class AssistantManager : AbsEmployee, ManagerIF {
        public AssistantManager() { position = "Assistant Manager"; }
        public AssistantManager(string name, double wage) {
            position = "Assistant Manager";
            this.name = name;
            this.wage = wage;
        }

        //Sets their supervisor if the supervisor is a higher rank
        public override bool SetHeadPerson(AbsEmployee parent) {
            //Can only have store manager as manager
            if (parent is StoreManagerIF) {
                this.parent = parent;
                parent.AssignEmployee(this);
                return true;
            }
            return false;
        }
    }

    /***Shift Supervisor is third from the top in hierarchy***/
    //Has marker interface SupervisorIF (used for composite pattern)
    internal class ShiftSupervisor : AbsEmployee, SupervisorIF {
        public ShiftSupervisor() { position = "Shift Supervisor"; }
        public ShiftSupervisor(string name, double wage) {
            position = "Shift Supervisor";
            this.name = name;
            this.wage = wage;
        }

        //Sets their supervisor if the supervisor is a higher rank
        public override bool SetHeadPerson(AbsEmployee parent) {
            //Can have any manager type (AssistantManger or StoreManager) as parent
            if (parent is ManagerIF) {
                this.parent = parent;
                parent.AssignEmployee(this);
                return true;
            }
            return false;
        }
    }

    /***Worker is lowest level of hierarchy***/
    internal class Worker : AbsEmployee {
        public Worker() { position = "Worker"; }
        public Worker(string name, double wage) {
            position = "Worker";
            this.name = name;
            this.wage = wage;
        }

        //Sets their supervisor if the supervisor is a higher rank
        public override bool SetHeadPerson(AbsEmployee parent) {
            //Can only have any supervisor as parent
            if (parent is SupervisorIF) {
                this.parent = parent;
                parent.AssignEmployee(this);
                return true;
            }
            return false;
        }
    }

    /**Null object***/
    internal class NullEmployee : AbsEmployee {
            public NullEmployee() {
                this.name = "";
                this.wage = 0;
                this.parent = null;
            }

        public override bool SetHeadPerson(AbsEmployee parent) {
            return true;
        }
    }

    /*** Marker Interfaces used for composite pattern***/
    internal interface SupervisorIF { }
    internal interface ManagerIF : SupervisorIF{ }
    internal interface StoreManagerIF: ManagerIF { }
}
