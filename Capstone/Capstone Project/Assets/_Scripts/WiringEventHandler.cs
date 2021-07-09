using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiringEventHandler : MonoBehaviour
{
    public int WiresSnapped;

    public bool CombustionFanCoverOn;
    public bool TopPanelOn;
    public bool BottomPanelOn;
    public GameObject EvaluationMenu;

    public GameObject EvaluationButton;

    public void WireTriggerPlaced()
    {
        WiresSnapped++;
        if(WiresSnapped >= 24)
        {
            EvaluationMenu.SetActive(true);
        }
    }

    public void WireTriggerRemoved()
    {
        WiresSnapped--;
    }

    public void CombustionFanCoverPlaced()
    {
        CombustionFanCoverOn = true;
        if (EvaluationMenu.activeInHierarchy && CombustionFanCoverOn == true && TopPanelOn == true && BottomPanelOn == true)
        {
            EvaluationButton.SetActive(true);
        }
    }

    public void CombustionFanCoverRemoved()
    {
        CombustionFanCoverOn = false;
    }
    public void TopPanelPlaced()
    {
        TopPanelOn = true;
        if (EvaluationMenu.activeInHierarchy && CombustionFanCoverOn == true && TopPanelOn == true && BottomPanelOn == true)
        {
            EvaluationButton.SetActive(true);
        }
    }

    public void TopPanelRemoved()
    {
        TopPanelOn = false;
    }

    public void BottomPanelPlaced()
    {
        BottomPanelOn = true;
        if(EvaluationMenu.activeInHierarchy && CombustionFanCoverOn == true && TopPanelOn == true && BottomPanelOn == true)
        {
            EvaluationButton.SetActive(true);
        }
    }

    public void BottomPanelRemoved()
    {
        BottomPanelOn = false;
    }
}
