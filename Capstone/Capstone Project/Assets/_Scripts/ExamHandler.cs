using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExamHandler : MonoBehaviour
{
    public PartnerColliderMerge[] BlackWiresToCheck;
    public PartnerColliderMerge[] YellowWiresToCheck;
    public PartnerColliderMerge[] GreenWiresToCheck;
    public PartnerColliderMerge[] RedWiresToCheck;
    public PartnerColliderMerge[] BlueWiresToCheck;
    public int score;
    public Text ScoreText;
    public GameObject ExitCube;

    public void Evaluation()
    {
        BlackWireEvaluation();
        YellowWireEvaluation();
        GreenWireEvaluation();
        RedWireEvaluation();
        BlueWireEvaluation();
        ExitCube.SetActive(true);
        ScoreText.text = score + "/11";
    }

    public void BlackWireEvaluation()
    {
        foreach(PartnerColliderMerge blackwire in BlackWiresToCheck)
        {
            if(blackwire.combinedTotal == 3 || blackwire.combinedTotal == 5 || blackwire.combinedTotal == 6 || blackwire.combinedTotal == 11)
            {
                score++;
            }
        }
    }

    public void YellowWireEvaluation()
    {
        foreach(PartnerColliderMerge yellowWire in YellowWiresToCheck)
        {
            if(yellowWire.combinedTotal == 3 || yellowWire.combinedTotal == 8)
            {
                score++;
            }
        }
    }

    public void GreenWireEvaluation()
    {
        foreach(PartnerColliderMerge greenWire in GreenWiresToCheck)
        {
            if (greenWire.combinedTotal == 3 || greenWire.combinedTotal == 8)
            {
                score++;
            }

        }
    }

    public void RedWireEvaluation()
    {
        foreach(PartnerColliderMerge redWire in RedWiresToCheck)
        { 
            if (redWire.combinedTotal == 8 || redWire.combinedTotal == 9)
            {
                score++;
            }
        }
    }

    public void BlueWireEvaluation()
    {
        foreach(PartnerColliderMerge blueWire in BlueWiresToCheck)
        {
            if (blueWire.combinedTotal == 8 || blueWire.combinedTotal == 9)
            {
                score++;
            }

        }
    }

    public void ResetSim()
    {
        SceneManager.LoadScene(0);
    }
}
