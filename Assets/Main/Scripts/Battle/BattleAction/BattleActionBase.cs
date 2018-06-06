﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

/// <summary>
/// 游戏里面的每一种效果
/// </summary>
public abstract class BattleActionBase
{

    private int ActionArg;
    private int ActionArg2;
    private BattleCardData CardData;
    private BattlePlayer Owner;
    private BattlePlayer Target;

    static Dictionary<BattleActionType, Type> dicActionType = null;

    static void Init()
    {
        Type baseType = typeof(BattleActionBase);
        Type[] types = Assembly.GetExecutingAssembly().GetExportedTypes();
        dicActionType = new Dictionary<BattleActionType, Type>(Enum.GetNames(typeof(BattleActionType)).Length);
        List<string> tableNames = new List<string>();
        Type type = null;
        for (int i = 0; i < types.Length; i++)
        {
            type = types[i];
            if (baseType != type && baseType.IsAssignableFrom(type))
            {

                dicActionType.Add((BattleActionType)type.GetProperty("ActionType", BindingFlags.Static | BindingFlags.Public).GetValue(null, null), type);
            }
        }
    }

    public static BattleActionBase Create(BattleActionType actionType, int actionArg, int actionArg2, BattleCardData cardData, BattlePlayer owner, BattlePlayer target)
    {
        if (dicActionType == null)
        {
            Init();
        }
        BattleActionBase battleAction = Activator.CreateInstance(dicActionType[actionType]) as BattleActionBase;
        battleAction.ActionArg = actionArg;
        battleAction.ActionArg2 = actionArg2;
        battleAction.CardData = cardData;
        battleAction.Owner = owner;
        battleAction.Target = target;
        return battleAction;
    }
    /// <summary>
    /// 效果的实现
    /// </summary>
    /// <param name="num"></param>
    public abstract void Excute();

}