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
        //If sphere has entered
        if(other.CompareTag("Sphere"))
        {
            //If sphere is not being grabbed
            if(!other.GetComponent<Rigidbody>().isKinematic)
            {
                //Box C
                if (isResetBox)
                {
                    PlayerManager.instance.ResetPosition();
                    other.GetComponent<SphereManager>().ResetPosition();
                    UIManager.instance.HideMainCanvas();
                }
                //Box A and B
                else
                {
                    uiPanel.SetActive(true);
                    particles.Play();
                    particles.GetComponent<AudioSource>().Play();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(uiPanel)
        {
            uiPanel.SetActive(false);
        }
    }
}
