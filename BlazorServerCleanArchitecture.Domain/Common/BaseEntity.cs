﻿namespace BlazorServerCleanArchitecture.Domain.Common
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}