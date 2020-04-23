﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRM.Core.Protocol
{
    /// <summary>
    /// not a real server model, just a placeholder to add a 'add server' button on list
    /// </summary>
    public class ProtocolServerNone : ProtocolServerBase
    {
        public override string ToJsonString()
        {
            return "";
        }

        public override ProtocolServerBase CreateFromJsonString(string jsonString)
        {
            throw new NotImplementedException();
        }

        public override string GetSubTitle()
        {
            return  "";
        }

        public ProtocolServerNone() : base("", "", "")
        {
        }
    }
}