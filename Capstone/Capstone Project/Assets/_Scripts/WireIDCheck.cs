using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireIDCheck : MonoBehaviour
{
    public int wireID;

    public SnapZoneWireCode SnapZoneCollided;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Black Snap") && gameObject.CompareTag("Black Wire"))
        {
            SnapZoneCollided = other.GetComponent<SnapZoneWireCode>();
            wireID = SnapZoneCollided.snapID;
        }

        if (other.gameObject.CompareTag("Yellow Snap") && gameObject.CompareTag("Yellow Wire"))
        {
            SnapZoneCollided = other.GetComponent<SnapZoneWireCode>();
            wireID = SnapZoneCollided.snapID;
        }

        if (other.gameObject.CompareTag("Green Snap") && gameObject.CompareTag("Green Wire"))
        {
            SnapZoneCollided = other.GetComponent<SnapZoneWireCode>();
            wireID = SnapZoneCollided.snapID;
        }

        if (other.gameObject.CompareTag("Red Snap") && gameObject.CompareTag("Red Wire"))
        {
            SnapZoneCollided = other.GetComponent<SnapZoneWireCode>();
            wireID = SnapZoneCollided.snapID;
        }

        if (other.gameObject.CompareTag("Blue Snap") && gameObject.CompareTag("Blue Wire"))
        {
            SnapZoneCollided = other.GetComponent<SnapZoneWireCode>();
            wireID = SnapZoneCollided.snapID;
        }
    }
}
