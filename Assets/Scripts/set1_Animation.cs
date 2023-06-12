using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set1_Animation : MonoBehaviour
{
    public GameObject set1;
    Animator set1Anim;
    void Start()
    {
        set1Anim = set1.GetComponent<Animator>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            set1Anim.SetInteger("set1OK", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            set1Anim.SetInteger("set1OK", 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            set1Anim.SetInteger("set1OK", 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            set1Anim.SetInteger("set1OK", 2);
        }
    }
}