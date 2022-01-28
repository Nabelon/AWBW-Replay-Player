﻿using System;
using System.Collections.Generic;
using AWBWApp.Game.Game.Logic;
using AWBWApp.Game.Helpers;
using Newtonsoft.Json.Linq;

namespace AWBWApp.Game.API.Replay.Actions
{
    public class ResignActionBuilder : IReplayActionBuilder
    {
        public string Code => "Resign";

        public ReplayActionDatabase Database { get; set; }

        //Todo: Figure out if anything of this is needed.
        public IReplayAction ParseJObjectIntoReplayAction(JObject jObject, ReplayData replayData, TurnData turnData) => null;
    }

    public class ResignAction : IReplayAction
    {
        public IEnumerable<ReplayWait> PerformAction(ReplayController controller)
        {
            //Todo: Need to complete the win screen
            throw new NotImplementedException();
        }

        public void UndoAction(ReplayController controller, bool immediate)
        {
            throw new NotImplementedException();
        }
    }
}
