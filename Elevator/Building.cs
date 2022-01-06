using System;
using System.Collections.Generic;

namespace Elevator
{
    public class Building {
        
        protected List<Floor> floors; 
        protected List<Elevator> elevators;

        public Building(int floorsAmount, int elevatorsAmount, int elevatorsCapacity, AbstractElevatorStrategy strategy) {
            floors = new List<Floor>();
            elevators = new List<Elevator>();
            for (int i = 0; i < floorsAmount; i++) {
                floors.Add(new Floor());
            }
            for (int i = 0; i < elevatorsAmount; i++) {
                elevators.Add(new Elevator(elevatorsCapacity, strategy));
            }
        }

        public int getAmountFloors()
        {
            return floors.Count;
        }

        public int getAmountElevators()
        {
            return elevators.Count;
        }

        public Floor GetFloor(int index)
        {
            return floors[index];
        }

        public Elevator GetElevator(int index)
        {
            return elevators[index];
        }

        public void configureElevators(int[] ar) {
            var i = 0;
            foreach (var elevator in elevators) {
                elevator.setCurrentFloor(i++);
            }
        }

        public bool complete() {
            foreach (var elevator in elevators) {
                if (elevator.getPeople().Count != 0) {
                    return false;
                }
            }
            foreach (var floor in floors) {
                foreach (var person in floor.getPeople()) {
                    if (person.getStatus() == PersonStatus.WAITING) {
                        return false;
                    }
                }
            }
            return true;
        }
        
        public void activateFireAlarm() {
            foreach (Elevator elevator in elevators) {
                foreach (Person person in elevator.getPeople()) {
                    person.setTargetFloor(0);
                }
                elevator.fireAlarmProtocol();
            }
            foreach (Floor floor in floors) {
                foreach (var person in floor.getPeople()) {
                    person.setStatus(PersonStatus.PANIC);
                }
            }
        }  
        
        public void spawnPerson(string name, int spawnFloor, int targetFloor) {
            this.floors[spawnFloor].enterFloor(new Person(name, spawnFloor, targetFloor));
            foreach (var elevator in elevators) {
                elevator.outerCall(spawnFloor);
            }
        }

        public void spawnPerson(Person person)
        {
            this.floors[person.getSpawnFloor()].enterFloor(person);
            foreach (var elevator in elevators)
            {
                elevator.outerCall(person.getSpawnFloor());
            }
        }

        public void act() {
            foreach (Elevator elevator in elevators) {
                if (elevator.move()) {
                    foreach (var el in elevators) {
                        el.removeOuterCall(elevator.getCurrentFloor());
                    }
                    elevator.activateDoors();
                    
                    this.floors[elevator.getCurrentFloor()].enterFloor(elevator.dropPeople());
                    
                    List<Person> peopleToLeave = floors[elevator.getCurrentFloor()].LeaveFloorToElevator();
                    foreach (var person in peopleToLeave) {
                        elevator.enterElevator(person);
                    }
                    elevator.activateDoors();
                }
            }
        }
    }
}
