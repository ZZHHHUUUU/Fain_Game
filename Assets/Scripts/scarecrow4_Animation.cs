using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scarecrow4_Animation : MonoBehaviour
{
    public GameObject scarecrow4;
    Animator scarecrow4Anim;
    void Start()
    {
        scarecrow4Anim = scarecrow4.GetComponent<Animator>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            scarecrow4Anim.SetInteger("scarecrow4OK", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            scarecrow4Anim.SetInteger("scarecrow4OK", 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            scarecrow4Anim.SetInteger("scarecrow4OK", 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            scarecrow4Anim.SetInteger("scarecrow4OK", 2);
        }
    }
}