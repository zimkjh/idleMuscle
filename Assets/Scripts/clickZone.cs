using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickZone : MonoBehaviour
{
    public DataStore dataStore;
    
    public void OnClick(){
        dataStore.incMuscleCount(1);
    }
}
