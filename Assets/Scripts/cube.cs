using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    private Vector3 point;
    private bool firstCube = true;

    private void Start()
    {
        if (firstCube)
        {
            point = transform.localPosition;
        }
    }

    public void Init(Vector3 pos)
    {
        point = pos;
        transform.localPosition = pos;
        firstCube = false;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "down")
        {
            GameObject cubePrefab = null;
            if (Random.Range(0, 2) == 0)
            {
                cubePrefab = Resources.Load<GameObject>("object/man-killer-halloween");
            }
            else
            {
                cubePrefab = Resources.Load<GameObject>("object/woman-witch-halloween");
            }

            if (cubePrefab != null)
            {
                // 生成新预制体
                GameObject instantiatedCube = GameObject.Instantiate(cubePrefab, point, Quaternion.identity, GameObject.Find("Target").transform);
                instantiatedCube.GetComponent<cube>().Init(point);
            }

            // 销毁当前游戏物体
            Destroy(gameObject);
        }
    }
}
