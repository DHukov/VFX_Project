using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TrafficState_Green
{
    protected TrafficLightManager traffic;
    protected TrafficState_Green(TrafficLightManager _trafic)
    {
        traffic = _trafic;
    }
    public virtual void Enter()
    {

    }
    public virtual void Exit()
    {

    }
    public virtual void Update()
    {

    }
}
