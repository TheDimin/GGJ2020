﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public static class EventHelper
{
    public static string[] GetAllEventStrings()
    {
        var derivedType = typeof(EventBase);
        var types = Assembly.GetAssembly(derivedType).GetTypes().Where(t => t != derivedType && derivedType.IsAssignableFrom(t)).ToArray();

        var newChoices = new string[types.Length];

        for (int i = 0; i < types.Length; i++)
        {
            newChoices[i] = types[i].ToString();
        }

        return newChoices.ToArray();
    }

    public static EventBase CreateEventByString(string EventID)
    {
        var derivedType = typeof(EventBase);
        var types = Assembly.GetAssembly(derivedType).GetTypes().Where(t => t != derivedType && derivedType.IsAssignableFrom(t)).ToArray();

        for (int i = 0; i < types.Length; i++)
        {
            if (types[i].ToString() == EventID)
            {
                return Activator.CreateInstance(types[i]) as EventBase;
            }
        }

        return null;
    }

    public static EventBase CreateEventByType(Type EventType)
    {
        return Activator.CreateInstance(EventType) as EventBase;
    }

    public static string[] GetAllRewardStrings()
    {
        var derivedType = typeof(RewardBase);
        var types = Assembly.GetAssembly(derivedType).GetTypes().Where(t => t != derivedType && derivedType.IsAssignableFrom(t)).ToArray();

        var newChoices = new string[types.Length];

        for (int i = 0; i < types.Length; i++)
        {
            newChoices[i] = types[i].ToString();
        }

        return newChoices.ToArray();
    }

    public static RewardBase CreateEffectByString(string EventID)
    {
        var derivedType = typeof(RewardBase);
        var types = Assembly.GetAssembly(derivedType).GetTypes().Where(t => t != derivedType && derivedType.IsAssignableFrom(t)).ToArray();

        for (int i = 0; i < types.Length; i++)
        {
            if (types[i].ToString() == EventID)
            {
                return Activator.CreateInstance(types[i]) as RewardBase;
            }
        }

        return null;
    }

    public static RewardBase CreateRewardByType(Type RewardType)
    {
        return Activator.CreateInstance(RewardType) as RewardBase;
    }
}
