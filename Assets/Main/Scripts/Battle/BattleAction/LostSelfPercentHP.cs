using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public partial class BattleAction
{
    public class LostSelfPercentHP : BattleActionBase
    {
        public BattleActionType ActionType { get { return BattleActionType.LostSelfPercentHP; } }
        public override void Excute()
        {
            throw new System.NotImplementedException();
        }
    }
}
