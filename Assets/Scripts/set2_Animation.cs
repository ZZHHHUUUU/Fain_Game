using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set2_Animation : MonoBehaviour
{
    public GameObject set2;
    Animator set2Anim;
    void Start()
    {
        set2Anim = set2.GetComponent<Animator>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            set2Anim.SetInteger("set2OK", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            set2Anim.SetInteger("set2OK", 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            set2Anim.SetInteger("set2OK", 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            set2Anim.SetInteger("set2OK", 2);
        }
    }
}