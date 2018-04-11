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
    }
}
