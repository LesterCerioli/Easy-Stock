using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStock.Domain.Entities
{
    public class City : Entity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int IdState { get; set; }
        public virtual State State { get; set; }
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddCritical("O preenchimento é obrigatório");
        }
    }
}
