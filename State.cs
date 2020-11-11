using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevator
{
    public abstract class State
    {
        protected Form1 _form1;

        public void SetContext(Form1 form1)
        {
            this._form1 = form1;
        }

        public abstract void MoveElevator(int floor);
    }

    public class StationaryState : State
    {
        override
            public void MoveElevator(int floor)
        {
            _form1.NextFloor = floor;
            _form1.toBeVisitedSet.Add(floor);
            _form1.visited[floor] = false;
            _form1.TransitionTo(new MovingState());
            _form1.timer1.Start();
        }
    }

    public class MovingState : State
    {
        override
            public void MoveElevator(int floor)
        {
            _form1.queueToBeVisited.Enqueue(floor);
            _form1.toBeVisitedSet.Add(floor);
            _form1.visited[floor] = false;
        }
    }

    //public class MovingDownState : State
    //{
    //    override
    //        public void MoveElevator(int floor)
    //    {
    //        HashSet<int> toBeVisited = _form1.toBeVisitedSet;
    //        if (!toBeVisited.Contains(floor))
    //        {
    //            toBeVisited.Add(floor);

    //            int currentFloor = _form1.currentFloor;
    //            List<SortedSet<int>> queue = _form1.queues;
    //            if (floor < currentFloor && floor > queue[0].Last())
    //            {
    //                queue[0].Add(_form1.nextFloor);
    //                _form1.nextFloor = floor;
    //            }
    //            else
    //            {
    //                if (floor < currentFloor && floor > queue[0].First())
    //                {
    //                    queue[0].Add(floor);
    //                }
    //                else
    //                {
    //                    if (queue.Count > 1)
    //                    {
    //                        for (int i = 1; i < queue.Count; i++)
    //                        {
    //                            SortedSet<int> previous = queue[i - 1];
    //                            SortedSet<int> next = queue[i];
    //                            if (floor > previous.Last())
    //                            {
    //                                if (floor < next.Last())
    //                                {
    //                                    next.Add(floor);
    //                                    return;
    //                                }
    //                            }
    //                            else if (floor < previous.Last())
    //                            {
    //                                if (floor > next.Last())
    //                                {
    //                                    next.Add(floor);
    //                                    return;
    //                                }
    //                            }
    //                        }
    //                        queue.Add(new SortedSet<int> { floor });
    //                    }
    //                    else
    //                    {
    //                        queue.Add(new SortedSet<int> { floor });
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}
}
