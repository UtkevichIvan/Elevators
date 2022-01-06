using System;
using System.Collections.Generic;

namespace Elevator
{
    public abstract class AbstractElevatorStrategy {

        public abstract bool move(List<int> innerCalls, List<int> outerCalls, int currentFloor, ref Direction dir);
        
        protected int getClosest(List<int> innerCalls, List<int> outerCalls, int currentFloor, bool isInner) {
            int delta = 1000;
            int priorFloor = currentFloor;
            foreach (int call in (isInner ? innerCalls : outerCalls)) {
                if (Math.Abs(currentFloor - call) < delta) {
                    delta = Math.Abs(currentFloor - call);
                    priorFloor = call;
                }
            }
            return priorFloor;
        }
    }
}