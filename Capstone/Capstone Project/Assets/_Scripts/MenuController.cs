using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject[] HandColliders;

    public GameObject[] Menus;
    public GameObject WiringDiagram;

    public ExamHandler Evaluate;

    public float HandDelayTime;
    public float CubeTouchDelay;

    private bool canPressButton = true;

    public enum ButtonInputTypes
    {
        MainMenu = 0,
        PracticeMenu = 1,
        ExamMenu = 2,
        DeactivateMenu = 3,
        Evaluation = 4
    }

    public void MainMenu()
    {
        if(canPressButton)
        {
            StartCoroutine(ButtonInputs(ButtonInputTypes.MainMenu));
        }
    }

    public void PracticeMenu()
    {
        if(canPressButton)
        {
            StartCoroutine(ButtonInputs(ButtonInputTypes.PracticeMenu));
        }
    }

    public void ExamMenu()
    {
        if (canPressButton)
        {
            StartCoroutine(ButtonInputs(ButtonInputTypes.ExamMenu));
        }
    }

    public void DeactivateMenu()
    {
        if (canPressButton)
        {
            StartCoroutine(ButtonInputs(ButtonInputTypes.DeactivateMenu));
        }
    }

    public void Evaluation()
    {
        if(canPressButton)
        {
            StartCoroutine(ButtonInputs(ButtonInputTypes.Evaluation));
        }
    }

    void MenuOff()
    {
        foreach (GameObject menu in Menus)
            menu.SetActive(false);
    }

    void ToggleMenuItems(string item)
    {
        foreach (GameObject menu in Menus)
            menu.SetActive(false);

        var obj = Menus.FirstOrDefault(ITEM => ITEM.name.Contains(item));
        if (item != null)
            obj.SetActive(true);
        else
            Debug.LogWarning("Could not find element " + item);
    }

    IEnumerator ButtonInputs(ButtonInputTypes inputType)
    {
        StartCoroutine(HandDelay());
        yield return new WaitForSeconds(CubeTouchDelay);
        switch(inputType)
        {
            case ButtonInputTypes.MainMenu:
                ToggleMenuItems("Main Menu");
                WiringDiagram.SetActive(false);
                break;
            case ButtonInputTypes.PracticeMenu:
                ToggleMenuItems("Practice Mode");
                WiringDiagram.SetActive(true);
                break;
            case ButtonInputTypes.ExamMenu:
                ToggleMenuItems("Exam Mode");
                WiringDiagram.SetActive(false);
                break;
            case ButtonInputTypes.DeactivateMenu:
                MenuOff();
                break;
            case ButtonInputTypes.Evaluation:
                Evaluate.Evaluation();
                break;

        }
        yield break;
    }

    IEnumerator HandDelay()
    {
        canPressButton = false;

        foreach(GameObject handCollider in HandColliders)
        {
            handCollider.SetActive(false);
        }

        yield return new WaitForSeconds(HandDelayTime);

        if(HandColliders != null)
        {
            foreach (GameObject handCollider in HandColliders)
            {
                handCollider.SetActive(true);
            }
        }

        canPressButton = true;

        yield break;
    }
}
