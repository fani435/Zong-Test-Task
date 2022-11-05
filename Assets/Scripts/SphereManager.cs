using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public Transform startingPointTransform;

    public void OnGrab()
    {
        GetComponent<AudioSource>().Play();
        UIManager.instance.ShowMainCanvas();
    }

    public void ResetPosition()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        transform.SetPositionAndRotation(startingPointTransform.position, startingPointTransform.rotation);
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
