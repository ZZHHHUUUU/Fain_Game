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

        StartCoroutine(DestroyAfterDelay(1f)); // ����Э�̣���1��������ӵ�
    }

    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // �ȴ�ָ�����ӳ�ʱ��

        Destroy(gameObject); // �����ӵ�����
    }
}
