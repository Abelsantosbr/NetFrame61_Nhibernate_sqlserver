using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetFrame61_Nhibernate_sqlserver.Models
{
    public class Funcionario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual int Idade { get; set; }
        public virtual double Salario { get; set; }
    }
}
