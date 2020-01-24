using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProyectoAplicada2.Data
{
    public class EmployeeServices
    {

        public bool CreateEmployess(Employees employees)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if(contexto.Employees.Add(employees)!=null)
                {
                    paso = contexto.SaveChanges() > 0;
                }

            }catch
            {
                throw;
            }
            return paso;
        }


    }
}
