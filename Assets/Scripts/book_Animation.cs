using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book_Animation : MonoBehaviour
{
    public GameObject book;
    Animator bookAnim;
    void Start()
    {
        bookAnim = book.GetComponent<Animator>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            bookAnim.SetInteger("bookOK", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            bookAnim.SetInteger("bookOK", 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            bookAnim.SetInteger("bookOK", 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            bookAnim.SetInteger("bookOK", 2);
        }
    }
}
