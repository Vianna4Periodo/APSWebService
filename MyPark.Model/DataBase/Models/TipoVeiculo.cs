﻿using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Models
{
    public class TipoVeiculo
    {
        public virtual Guid Id { get; set; }
        public virtual String Titulo { get; set; }
        public virtual String Descricao { get; set; }
        public virtual Double ValorHora { get; set; }
        public virtual DateTime DtCadastro { get; set; }
        public virtual int Inativo { get; set; }
        public virtual IList<Veiculo> Veiculos { get; set; }

        public TipoVeiculo()
        {
            this.Veiculos = new List<Veiculo>();
        }
    }

    public class TipoVeiculoMap : ClassMapping<TipoVeiculo>
    {
        public TipoVeiculoMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Guid));

            Property(x => x.Titulo);
            Property(x => x.Descricao);
            Property(x => x.ValorHora);
            Property(x => x.DtCadastro);
            Property(x => x.Inativo);

            Bag(x => x.Veiculos, m =>
            {
                m.Cascade(Cascade.Detach);
                m.Lazy(CollectionLazy.Lazy);
                m.Key(k => k.Column("idTipo"));
                m.Inverse(true);
            },
            r => r.OneToMany());
        }
    }
}
