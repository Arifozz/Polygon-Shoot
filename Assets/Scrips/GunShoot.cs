using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public float damage;
    public float range = 100f;
    public float magazine;
    public Camera playerCam;

    public float fireRate = 0.15f;
    private float nextTimeToFire=0f;

    public float reloadTime;
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && magazine>0 && Time.time>=nextTimeToFire)
        {
            nextTimeToFire = Time.time + fireRate;
            if (magazine > 0)
                Shoot();

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Şarjör Dolduruluyor!");
            Invoke("Reload", reloadTime);
        }
    }
    void Shoot()
    {
        Debug.Log("Ateş Edildi!");
        magazine--;
        if (magazine == 0)
        {
            Debug.Log("Şarjör Boş!");
        }

        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range))
        {
            if (hit.collider.gameObject.tag == "Target")
            {
                Debug.Log("Hedefi Vurdun!");
                hit.collider.gameObject.GetComponent<Target>().TakeDamage(damage);
            }
            else
                Debug.Log("Hedefi Vuramadın!");
        }
    }
    void Reload()
    {
        magazine = 30;
    }
}
