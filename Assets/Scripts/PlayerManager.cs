using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Transform startingPointTransform;
    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void ResetPosition()
    {
        GetComponent<CharacterController>().enabled = false;
        transform.SetPositionAndRotation(startingPointTransform.position, startingPointTransform.rotation);
        GetComponent<CharacterController>().enabled = true;
    }
}
