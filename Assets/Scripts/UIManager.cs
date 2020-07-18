using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public DataController dataController;
    public Text goldDisplayer;
    
    void Update() {
        goldDisplayer.text = "Gold : "+ dataController.GetGold();
    }
}
