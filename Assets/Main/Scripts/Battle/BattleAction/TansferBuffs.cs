using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public partial class BattleAction
{
    public class TansferBuffs : BattleActionBase
    {
        public BattleActionType ActionType { get { return BattleActionType.TansferBuffs; } }
        public override void Excute()
        {
            throw new System.NotImplementedException();
        }
    }
}
