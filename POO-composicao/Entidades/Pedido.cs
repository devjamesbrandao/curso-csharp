using System;
using C_.Entidades.Enums;

namespace C_.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public Status Status { get; set; }

    }
}