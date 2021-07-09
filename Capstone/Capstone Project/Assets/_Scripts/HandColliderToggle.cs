using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColliderToggle : MonoBehaviour
{
    public GameObject[] HandColliders;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Button"))
        {
            StartCoroutine(HandToggle());
        }
    }

    IEnumerator HandToggle()
    {
        foreach(GameObject handCollider in HandColliders)
        {
            handCollider.SetActive(false);
        }
        yield return new WaitForSeconds(1);
        foreach (GameObject handCollider in HandColliders)
        {
            handCollider.SetActive(true);
        }
    }
}
