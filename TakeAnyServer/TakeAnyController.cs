using System;
using System.Collections.Generic;
using System.Text;
using TakeAnyCommon;

namespace Controller
{
    public class TakeAnyController
    {
        private TakeAnyState _controllerState = TakeAnyState.None;
        private InputSystem _input;
        public async Task Run()
        {
            if (_controllerState == TakeAnyState.Running) return;
            _controllerState = TakeAnyState.Running;
            CancellationTokenSource cts = new CancellationTokenSource();
            _input = new InputSystem();
            _ = _input.Run(cts.Token);

        }
        
    }
}
