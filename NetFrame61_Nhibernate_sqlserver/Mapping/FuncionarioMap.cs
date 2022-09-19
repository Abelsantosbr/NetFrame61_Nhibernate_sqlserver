using FluentNHibernate.Mapping;
using NetFrame61_Nhibernate_sqlserver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFrame61_Nhibernate_sqlserver.Mapping
{
    public class FuncionarioMap : ClassMap<Funcionario>
    {
        public FuncionarioMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Idade);
            Map(x => x.Salario);
            Table("funcionarios");
        }
    }
}

