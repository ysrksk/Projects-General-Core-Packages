﻿namespace Core.Persistance.Repositories
{
    public interface IEntityTimestamps
    {
        DateTime CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
