using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Models
{
    public class Passagem
    {
        public virtual Guid Id { get; set; }
        public virtual Voo Voo { get; set; }

        public Double Valor
        {
            get
            {
                return this.Voo.Preco;
            }
        }

        public DateTime Data
        {
            get
            {
                return this.Voo.Data;
            }
        }

        public DateTime Hora
        {
            get
            {
                return this.Voo.Hora;
            }
        }
    }

    public class PassagemMap : ClassMapping<Passagem>
    {
        public PassagemMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));

            ManyToOne(x => x.Voo, m =>
            {
                m.Column("idVoo");
                m.Lazy(LazyRelation.NoLazy);
            });
        }
    }
}
