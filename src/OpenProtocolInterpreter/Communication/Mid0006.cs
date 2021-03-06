﻿using System;

namespace OpenProtocolInterpreter.Communication
{
    /// <summary>
    /// MID: Application Communication positive acknowledge
    /// Description: 
    ///     Do a request for data. This message is used for ALL request handling.
    ///     When used it substitutes the use of all MID special request messages.
    ///     NOTE! The Header Revision field is the revision of the MID 0006 itself NOT 
    ///     the revision of the data MID that is wanted to be uploaded.
    /// 
    /// Message sent by: Integrator
    /// Answer: MID Requested for or MID 0004 Command error. Error described at each MID description.
    /// </summary>
    public class Mid0006 : Mid, ICommunication
    {
        private const int LAST_REVISION = 1;
        public const int MID = 6;

        public int MIDAccepted { get; set; }

        public Mid0006() : base(MID, LAST_REVISION)
        {

        }

        internal Mid0006(IMid nextTemplate) : this()
        {
            NextTemplate = nextTemplate;
        }

        public override string Pack()
        {
            throw new NotImplementedException();
        }

        public override Mid Parse(string package)
        {
            throw new NotImplementedException();
        }
    }
}
