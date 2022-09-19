using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NetFrame61_Nhibernate_sqlserver.Models;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFrame61_Nhibernate_sqlserver.NHibernateCfg
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                  .ConnectionString("Server = (localdb)\\MSSQLLocaldb; Database=cadastro; Integrated Security = true;")
                                          .ShowSql()
                )
               .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<Funcionario>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                                                .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}