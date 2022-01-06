namespace Elevator
{
    public class Person {
        
        protected string name;
        protected PersonStatus status;
        protected int spawnFloor;
        protected int targetFloor;

        public Person(string name, int spawnFloor, int targetFloor, PersonStatus status = PersonStatus.WAITING) {
            this.name = name;
            this.status = status;
            this.spawnFloor = spawnFloor;
            this.targetFloor = targetFloor;
        }

        public override string ToString()
        {
            return name;
        }

        public string getName() {
            return this.name;
        }

        public PersonStatus getStatus() {
            return this.status;
        }

        public void setStatus(PersonStatus personStatus) {
            this.status = personStatus;
        }

        public int getSpawnFloor() {
            return this.spawnFloor;
        }

        public int getTargetFloor() {
            return this.targetFloor;
        }

        public void setTargetFloor(int targetFloor) {
            this.targetFloor = targetFloor;
        }

    }
    
}
