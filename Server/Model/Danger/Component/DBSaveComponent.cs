using System.Collections.Generic;
using System;

namespace ET
{
    public class DBSaveComponent : Entity, IAwake, IDestroy, ITransfer
    {
        public long Timer;
        public long DBInterval;

        public List<string> ChangeComponent = new List<string>();
    }
}
