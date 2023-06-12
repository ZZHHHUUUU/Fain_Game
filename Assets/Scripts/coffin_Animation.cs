using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffin_Animation : MonoBehaviour
{
    public GameObject coffin4;
    Animator coffin4Anim;
    void Start()
    {
        coffin4Anim = coffin4.GetComponent<Animator>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            coffin4Anim.SetInteger("coffinOK", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            coffin4Anim.SetInteger("coffinOK", 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            coffin4Anim.SetInteger("coffinOK", 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            coffin4Anim.SetInteger("coffinOK", 2);
        }
    }
}