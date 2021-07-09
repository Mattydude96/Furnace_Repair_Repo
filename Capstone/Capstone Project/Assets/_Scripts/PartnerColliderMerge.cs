using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerColliderMerge : MonoBehaviour
{
    public WireIDCheck selfID;
    public WireIDCheck partnerID;

    public int combinedTotal;

    private void Start()
    {
        selfID = GetComponent<WireIDCheck>();
    }

    public void CombineID()
    {
        combinedTotal = (selfID.wireID + partnerID.wireID);
    }
}
