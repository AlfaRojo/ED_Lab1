using System;

namespace Lab1.Models
{
    public class Index<TK, TP> : IEquatable<Index<TK,TP>>
    {
        public TK ID { get; set; }
        public TP Pointer { get; set; }

        public bool Equals(Index<TK, TP> other)
        {
            return this.ID.Equals(other.ID) && this.Pointer.Equals(other.Pointer);
        }

    }
}
