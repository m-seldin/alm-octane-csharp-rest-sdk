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

namespace Hpe.Nga.Api.Core.Connector
{
    /// <summary>
    /// POCO class for connection data that is sent to NGA server during calling to <see cref="Connect"/> method.
    /// Uses the user/password method
    /// </summary>
    public class UserPassConnectionInfo : ConnectionInfo
    {
        public string user { get; set; }
        public string password { get; set; }

       /* public string enable_csrf
        {
            get
            {
                return "true";
            }
        }*/


        public UserPassConnectionInfo()
        {
        }

        public UserPassConnectionInfo(String user, string password)
        {
            this.user = user;
            this.password = password;
        }
    }
}
