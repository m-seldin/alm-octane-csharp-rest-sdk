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
using System.Threading.Tasks;
using Hpe.Nga.Api.Core.Services;

namespace Hpe.Nga.Api.Core.Entities
{
    /// <summary>
    /// Base class for all WorkItem entities.
    /// More fields might be supported by entity that still are not exposed in the class
    /// </summary>
    public class WorkItem : BaseEntity
    {
        public static string SUBTYPE_FIELD = "subtype";
        public static string RELEASE_FIELD = "release";
        public static string PHASE_FIELD = "phase";
        public static string SEVERITY_FIELD = "severity";
        public static string PARENT_FIELD = "parent";
        public static string DESCRIPTION_FIELD = "description";



        public static string SUBTYPE_DEFECT = "defect";
        public static string SUBTYPE_STORY = "story";
        public static string SUBTYPE_QUALITY_STORY = "quality_story";
        public static string SUBTYPE_FEATURE = "feature";
        public static string SUBTYPE_EPIC = "epic";

        public WorkItem()
        {
            AggregateType = "work_item";
        }

        public WorkItem(EntityId id)
            : base(id)
        {
            AggregateType = "work_item";
        }

        public string SubType
        {
            get
            {
                return GetStringValue(SUBTYPE_FIELD);
            }
            set
            {
                SetValue(SUBTYPE_FIELD, value);
            }

        }

        public Phase Phase
        {
            get
            {
                return (Phase)GetValue(PHASE_FIELD);
            }
            set
            {
                SetValue(PHASE_FIELD, value);
            }
        }

        public ListNode Severity
        {
            get
            {
                return (ListNode)GetValue(SEVERITY_FIELD);
            }
            set
            {
                SetValue(SEVERITY_FIELD, value);
            }
        }

        public BaseEntity Parent
        {
            get
            {
                return (BaseEntity)GetValue(PARENT_FIELD);
            }
            set
            {
                SetValue(PARENT_FIELD, value);
            }
        }


        public Release Release
        {
            get
            {
                return (Release)GetValue(RELEASE_FIELD);
            }
            set
            {
                SetValue(RELEASE_FIELD, value);
            }
        }
        public string Description
        {
            get
            {
                return GetStringValue(DESCRIPTION_FIELD);
            }
            set
            {
                SetValue(DESCRIPTION_FIELD, value);
            }
        }
    }
}
