using System;
using System.Collections.Generic;
using System.Text;
using TakeAnyCommon;

namespace TakeAny
{
    public class TakeAnyClient
    {
        private TakeAnyState _clientState = TakeAnyState.None;
        public async Task Run()
        {
            if (_clientState == TakeAnyState.Running) return;
            _clientState = TakeAnyState.Running;

        }
    }
}
