using System.Collections.Generic;
using System.Linq;

namespace Elevator
{
    
    public class Floor {
        protected List<Person> persons;

        public Floor() {
            persons = new List<Person>();
        }
        
        public List<Person> LeaveFloorToElevator() {
            List<Person> personsToEnterElevator = new List<Person>();
            for (int i = 0; i < persons.Count;) {
                if (persons[i].getStatus() == PersonStatus.WAITING) {
                    persons[i].setStatus(PersonStatus.MOVING);
                    personsToEnterElevator.Add(persons[i]);
                    persons.Remove(persons[i]);
                } else {
                    i++;
                }
            }
            return personsToEnterElevator;
        }

        public void enterFloor(List<Person> people) {
            List<Person> newList = new List<Person>(persons.Concat(people).ToList());
            this.persons = newList;
        }

        public void enterFloor(Person person) {
            this.persons.Add(person);
        }

        public List<Person> getPeople() {
            return this.persons;
        }

        public int getWaitingPeople()
        {
            int x = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].getStatus() == PersonStatus.WAITING)
                {
                    x++;
                }
            }
            return x;
        }

        public int getArrivedPeople()
        {
            int x = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].getStatus() == PersonStatus.ARRIVED)
                {
                    x++;
                }
            }
            return x;
        }

    }
    
}