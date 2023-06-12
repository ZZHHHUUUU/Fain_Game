using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    private GameObject prefab_Bullet;
    private bool canShoot = true;

    void Start()
    {
        prefab_Bullet = Resources.Load<GameObject>("CubeShooter/prefab_Bullet");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            Shoot();
            canShoot = false;
            StartCoroutine(ShootCooldown(0.5f));
        }
    }

    IEnumerator ShootCooldown(float cooldownTime)
    {
        yield return new WaitForSeconds(cooldownTime);
        canShoot = true;
    }

    private void Shoot()
    {
        GameObject bulletPrefab = Resources.Load<GameObject>("object/Bullet");
        Bullet bullet = Instantiate(bulletPrefab, Camera.main.transform.position, Quaternion.identity).GetComponent<Bullet>();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        bullet.Init(ray.direction * 2000);
    }
}