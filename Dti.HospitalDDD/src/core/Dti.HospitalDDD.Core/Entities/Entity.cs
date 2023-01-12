namespace Dti.HospitalDDD.Core.Entities
{
    public abstract class Entity
    {
        protected Entity(Guid id)
        {
            Id = id;
            Excluido = false;
            DataCriacao = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public bool Excluido { get; private set; }
        public DateTime DataCriacao { get; private set; }

    }
}
