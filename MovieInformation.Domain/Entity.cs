    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace MovieInformation.Domain
    {
        public abstract class Entity
        {
            protected Entity()
            {
                Id = Guid.NewGuid();
            }

            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public Guid Id { get; set; }
        }
}