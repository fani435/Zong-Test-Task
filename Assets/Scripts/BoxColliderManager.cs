using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderManager : MonoBehaviour
{
    public GameObject uiPanel;
    public ParticleSystem particles;
    public bool isResetBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isResetBox)
        {
            PlayerManager.instance.ResetPosition();
        }
        else
        {
            uiPanel.SetActive(true);
            particles.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        uiPanel.SetActive(false);
    }
}
