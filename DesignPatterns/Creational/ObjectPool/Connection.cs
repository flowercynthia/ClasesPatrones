using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    public class Connection
    {
        public bool IsOpen { get; private set; }
        public Connection()
        {
            this.IsOpen = false;
        }

        public void Open()
        {
            this.IsOpen = true;
        }
        public void Close()
        {
            this.IsOpen = false;
        }
    }
}
