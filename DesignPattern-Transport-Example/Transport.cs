using System.Collections.Generic;

namespace DesignPattern_Example
{
    public abstract class Transport
    {
        protected abstract IEngine CarEngine { get; }
        protected abstract List<IDriver> GetDrivers();

        public virtual void ShowEngine()
        {
            CarEngine.Move();
        }

        public virtual void DriveTransport()
        {
            GetDrivers().ForEach(item => { item.Drive(); });
        }
    }
}
