using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    public class ConnectionPool : AbstractObjectPool<Connection>
    {
        public override Connection Create()
        {
            var connection = new Connection();
            connection.Open();
            return connection;
        }

        public override void Expire(Connection obj)
        {
            obj.Close();
        }

        public override bool Validate(Connection obj)
        {
            return obj.IsOpen;
        }
    }
}
