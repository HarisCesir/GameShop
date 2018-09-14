using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Util
{
   public class ExceptionHandler
    {
       public static void HandleException(EntityException e)
       {
           SqlException error = (SqlException)e.InnerException;

           switch (error.Number)
           {
               case 2627:
                 throw  throwNewConstraintException(error);
               default:
                 throw new Exception(error.Message);
           }
       }

       private static ConstraintException throwNewConstraintException(SqlException error)
       {
           int pocetak = error.Message.IndexOf("'");
           int kraj = error.Message.IndexOf("'", pocetak + 1);

           string poruka = error.Message;

           if (pocetak > 0 && kraj > 0)
           {
               string cname = error.Message.Substring(pocetak + 1, kraj - pocetak-1);

               if (cname == "korisnickoIme")
                   poruka = "username_con";
               else
                   if (cname == "Email")
                       poruka = "email_con";

           }
           return new ConstraintException(poruka);
       }
    }
}
