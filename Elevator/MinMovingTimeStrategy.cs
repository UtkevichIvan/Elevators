using System;
using System.Collections.Generic;

namespace Elevator
{
    
    public class MinMovingTimeStrategy : AbstractElevatorStrategy {
        
        public override bool move(List<int> innerCalls, List<int> outerCalls, int currentFloor, ref Direction dir) {
            if (innerCalls.Count == 0) {
                int target = getClosest(innerCalls, outerCalls, currentFloor, false);
                if (target > currentFloor) {
                    dir = Direction.UP;
                } else if (target < currentFloor) {
                    dir = Direction.DOWN;
                }
                if (currentFloor == target) {
                    return true;
                }
            } else {
                int target = getClosest(innerCalls, outerCalls, currentFloor, true);
                if (target > currentFloor) {
                    dir = Direction.UP;
                } else if (target < currentFloor) {
                    dir = Direction.DOWN;
                }
                if (currentFloor == target) {
                    return true;
                }
            }
            return false;
        }
    }
}
