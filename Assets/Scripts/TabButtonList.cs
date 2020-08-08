using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TabButtonList : MonoBehaviour
{
    private TabButton selectedTabButton;

    private GameObject tabArea;

    private void Start()
    {
        selectedTabButton = GameObject.Find("TabButton1").GetComponent<TabButton>();
    }

    public void selectTabButton(TabButton tabButton)
    {
        if (selectedTabButton != tabButton)
        {
            tabArea = selectedTabButton.getTabArea();
            tabArea.SetActive(false);
            selectedTabButton = tabButton;
            tabArea = selectedTabButton.getTabArea();
            tabArea.SetActive(true);
        }
    }
}
