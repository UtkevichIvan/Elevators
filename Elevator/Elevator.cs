using System; 
using System.Collections.Generic;

namespace Elevator
{
    
    public class Elevator { 
        protected List<Person> people; 
        protected int capacity;
        protected int currentFloor;
        protected List<int> innerCalls;
        protected List<int> outerCalls;
        protected AbstractElevatorStrategy strategy;
        protected int delivered;
        protected DoorStatus doorStatus;

        public bool move() {
            Direction dir = Direction.STAY;
            bool success =  this.strategy.move(innerCalls, outerCalls, currentFloor, ref dir);
            if (dir == Direction.UP) {
                currentFloor++;
            } else if (dir == Direction.DOWN) {
                currentFloor--;
            }
            return success;
        }

        public void setCurrentFloor(int n) {
            this.currentFloor = n;
        }

        public Elevator(int capacity, AbstractElevatorStrategy strategy) {
            this.people = new List<Person>();
            this.capacity = capacity;
            this.strategy = strategy;
            this.currentFloor = 0;
            this.innerCalls = new List<int>();
            this.outerCalls = new List<int>();
            this.delivered = 0;
            this.doorStatus = DoorStatus.CLOSED;
        } 
 
        public void activateDoors() {
            doorStatus = doorStatus == DoorStatus.OPENED ? DoorStatus.CLOSED : DoorStatus.OPENED;
        }

        public int getDelivered()
        {
            return delivered;
        }

        public List<Person> dropPeople() {
            List<Person> peopleToLeave = new List<Person>();
            for (int i = 0; i < this.people.Count;) {
                if (this.currentFloor == this.people[i].getTargetFloor()) {
                    this.people[i].setStatus(PersonStatus.ARRIVED);
                    peopleToLeave.Add(this.people[i]);
                    this.innerCalls.Remove(this.people[i].getTargetFloor());
                    this.people.Remove(this.people[i]);
                    delivered++;
                } else {
                    i++;
                }
            }
            return peopleToLeave;
        }

        public int getAmountOfPeople()
        {
            return people.Count;
        }

        public List<Person> getPeople() {
            return this.people;
        }
        
        public void enterElevator(Person person) {
            this.people.Add(person);
            innerCall(person.getTargetFloor());
        }

        public int getCurrentFloor() {
            return this.currentFloor;
        }
        
        public void innerCall(int floor) {
            if (!innerCalls.Contains(floor)) {
                this.innerCalls.Add(floor);
            }
        }

        public void outerCall(int floor) {
            if (!outerCalls.Contains(floor)) {
                this.outerCalls.Add(floor);
            }
        }

        public void removeOuterCall(int floor) {
            this.outerCalls.Remove(floor);
        }
        
        public void fireAlarmProtocol() {
            this.innerCalls.Clear();
            this.outerCalls.Clear();
            this.innerCalls.Add(0);
        }

        public List<int> getInnerCalls() {
            return this.innerCalls;
        }
        public List<int> getOuterCalls() {
            return this.outerCalls;
        }

        public DoorStatus getDoorStatus() {
            return this.doorStatus;
        }

    } 
    
}
