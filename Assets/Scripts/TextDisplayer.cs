using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayer : MonoBehaviour
{
    public DataStore dataStore;
    public Text muscleText;
    private void Update() {
        muscleText.text = "근육량 : " + dataStore.getMuscleCount();
    }
}
