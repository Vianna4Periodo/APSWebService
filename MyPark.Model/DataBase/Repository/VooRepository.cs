using MyPark.Model.DataBase.Models;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Repository
{
    public class VooRepository : RepositoryBase<Voo>
    {
        public VooRepository(ISession session) : base(session) { }

        public Voo FindByNumero(int Numero)
        {
            return this.Session.CreateCriteria<Voo>()
                        .Add(Restrictions.Eq("Numero", Numero))
                        .SetMaxResults(1)
                        .List<Voo>()
                        .FirstOrDefault();
        }
    }
}
