using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public abstract class Base : IEntityKey<int>, IIsDeleted
    {

        /// <summary>
        /// Tüm Entity lerde ortak olan property ler için Base class oluşturuldu.
        /// Bu sayede diğer entity lerde bu property leri tek tek yazmak zorunda kalmadık.
        /// </summary>

        public int Id { get; set; }

        public bool IsDeleted { get; set; }
    }
}
