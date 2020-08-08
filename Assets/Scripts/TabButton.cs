using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabButton : MonoBehaviour
{
    public TabButtonList tabButtonList;
    private GameObject tabArea;
    private string tabAreaName;
    void Start()
    {
        tabAreaName = "TabArea" + this.name.Substring(9);
        tabArea = GameObject.Find(tabAreaName);
        if (tabAreaName != "TabArea1")
        {
            tabArea.SetActive(false);
        }
    }

    public void onClick()
    {
        tabButtonList.selectTabButton(this);
    }

    public GameObject getTabArea()
    {
        return tabArea;
    }
}
