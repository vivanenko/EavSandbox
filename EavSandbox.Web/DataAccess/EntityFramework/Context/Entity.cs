﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EavSandbox.Web.EntityFramework.Context
{
    public class Entity
    {
        public int Id { get; set; }

        public Category Category { get; set; }

        public ICollection<AttributeValue> AttributeValues { get; set; } = new Collection<AttributeValue>();

        public ICollection<Entity> Entities { get; set; } = new Collection<Entity>();
    }
}
