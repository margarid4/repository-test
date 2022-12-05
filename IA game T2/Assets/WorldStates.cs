using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WorldStates
{
   public string key;
   public int value;

}


public class WorldStates 
{
   public Dictionary<string , int> states;
   public WorldStates()
   {
        states = new Dictionary<string , int>();
    }

    public bool HasState(string key)
    {
        return states.Containskey(key);
    }

    void AddState(string key, int value)
    {
        states.Add(key, value);
    }

    public void ModifyState(string key, int value)
    {
        if(states.Containskey(key))
        {
        states[key] += value;
        if(states[key] <= 0)
         RemoveState(key);
       }

       else 
         states.Add(key, value);

    }

    public void RemoveState(string key)
    { 
        if(states.Containskey(key))
        states.Remove(key);
    }

    public void SetState(string key, int value)
    { 
        if(states.Containskey(key))
           states[key] =value;
        else
           states.Add(key, value);
    }

    public Dictionary<string, int> GetStates()
    { 
        return states;
    }


}
