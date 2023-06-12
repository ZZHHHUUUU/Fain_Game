using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody myRigidBody;

    // Start is called before the first frame update
    public void Init(Vector3 force)
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.AddForce(force);

        StartCoroutine(DestroyAfterDelay(1f)); // 调用协程，在1秒后销毁子弹
    }

    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // 等待指定的延迟时间

        Destroy(gameObject); // 销毁子弹对象
    }
}
