﻿using CoAPnet.Protocol.Options;
using System;
using System.Collections.Generic;

namespace CoAPnet.Protocol
{
    public sealed class CoapMessage
    {
        public CoapMessageType Type
        {
            get; set;
        }

        public byte[] Token
        {
            get; set;
        }

        public CoapMessageCode Code
        {
            get; set;
        }

        public ushort Id
        {
            get; set;
        }

        public List<CoapMessageOption> Options
        {
            get; set;
        }

        public ArraySegment<byte> Payload
        {
            get; set;
        }

        public byte[] PayloadBytes { get; set; }
    }
}