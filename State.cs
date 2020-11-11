using System;

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
}
