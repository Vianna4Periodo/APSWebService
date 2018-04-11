using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Models
{
    public class Voo
    {
        public virtual Guid Id { get; set; }
        public virtual String Aeronave { get; set; }
        public virtual int Numero { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual DateTime Hora { get; set; }
        public virtual String Destino { get; set; }
        public virtual int QtdAssentos { get; set; }
        public virtual Double Preco { get; set; }
        public List<Passagem> Passagens { get; set; }

        public int AssentosDisponiveis
        {
            get
            {
                return QtdAssentos - Passagens.Count;
            }
        }

        public bool IsPossibleAddPassagem
        {
            get
            {
                return this.AssentosDisponiveis >= 1;
            }
        }

        public Voo()
        {
            this.Passagens = new List<Passagem>();
        }
    }

    public class VooMap : ClassMapping<Voo>
    {
        public VooMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));

            Property(x => x.Aeronave);
            Property(x => x.Numero);
            Property(x => x.Data);
            Property(x => x.Hora);
            Property(x => x.Destino);
            Property(x => x.QtdAssentos);
            Property(x => x.Preco);

            Bag(x => x.Passagens, m =>
            {
                m.Cascade(Cascade.Detach);
                m.Lazy(CollectionLazy.Lazy);
                m.Key(k => k.Column("idVoo"));
                m.Inverse(true);
            },
            r => r.OneToMany());
        }
    }
}
