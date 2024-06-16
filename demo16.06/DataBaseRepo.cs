using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace demo16._06
{
    internal class DataBaseRepo
    {
        
        public static  user Authorization(string Login, string password)
        {
            var user = _context.user.FirstOrDefault(x => x.login == Login && x.password == password);
            if (user == null)
            {
                return null;
            }
            else
            {
                return user;
            }

        }

      
        public static IEnumerable<user> GetUsers()
        {
            return _context.user.ToList();
        }

        public static Demo09062024Entities _context= new Demo09062024Entities();

        public static void AddShift(shift shiftt)
        {
            _context.shift.Add(shiftt);
            _context.SaveChanges();
        }

        public static void ChangeOrderStatus(int Id)
        {
            var order= _context.order.FirstOrDefault(x=>x.orderid==Id+1);
            if (order.orderstatus == "готов")
            {
                order.orderstatus = "готовится";
            }
            else
            {
                order.orderstatus = "готов";
            }
            _context.order.AddOrUpdate(order);
            _context.SaveChanges();
        }

        
        public static void AddOrder(order order)
        {
            _context.order.Add(order);
            _context.SaveChanges();
        }

    }
    
}
