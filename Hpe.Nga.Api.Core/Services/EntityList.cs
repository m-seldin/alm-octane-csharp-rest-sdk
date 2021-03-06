﻿// (c) Copyright 2016 Hewlett Packard Enterprise Development LP

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.

// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS,

// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

// See the License for the specific language governing permissions and limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hpe.Nga.Api.Core.Entities;

namespace Hpe.Nga.Api.Core.Services
{
    /// <summary>
    /// List that used for POST/PUT requests
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EntityList<T> where T : BaseEntity
    {
        public EntityList()
        {
            data = new List<T>();
        }

        public EntityList(T entity)
        {
            data = new List<T>();
            data.Add(entity);
        }

        public static EntityList<T> Create(T entity)
        {
            return new EntityList<T>(entity);
        }

        public List<T> data { get; set; }
    }
}
