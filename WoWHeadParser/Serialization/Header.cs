﻿using System.Runtime.Serialization;

namespace WoWHeadParser.Serialization
{
    [DataContract]
    public class Header
    {
        [DataMember]
        public int Version;

        [IgnoreDataMember]
        public static int CurrentVersion = 1;
    }
}
