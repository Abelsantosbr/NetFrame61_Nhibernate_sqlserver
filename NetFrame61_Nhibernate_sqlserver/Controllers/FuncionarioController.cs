using NetFrame61_Nhibernate_sqlserver.Models;
using NetFrame61_Nhibernate_sqlserver.NHibernateCfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFrame61_Nhibernate_sqlserver.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var funcionarios = session.Query<Funcionario>().ToList();
                return View(funcionarios);
            }
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int? id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var funcionario = session.Get<Funcionario>(id);
                return View(funcionario);
            }
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        public ActionResult Create(Funcionario funcionario)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(funcionario);
                        transaction.Commit();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var funcionario = session.Get<Funcionario>(id);
                return View(funcionario);
            }
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Funcionario funcionario)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    var funcionarioUpdate = session.Get<Funcionario>(id);

                    funcionarioUpdate.Nome = funcionario.Nome;
                    funcionarioUpdate.Idade = funcionario.Idade;
                    funcionarioUpdate.Salario = funcionario.Salario;

                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(funcionarioUpdate);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var funcionario = session.Get<Funcionario>(id);
                return View(funcionario);
            }
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Funcionario funcionario)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(funcionario);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }
    }
}
