using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public float health = 100f;
    private TextMesh healthText;

    private void Start()
    {
        healthText = GetComponentInChildren<TextMesh>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnemySetActive(true);
            Debug.Log("Hedef Yeniden Aktif!");
            health = 100;

        }
        healthText.text = health.ToString();
    }

    public void TakeDamage (float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            EnemySetActive(false);
            Debug.Log("Hedef Artık Kullanılamaz!");
        }
    }

    private void EnemySetActive(bool enable)
    {
        GetComponent<BoxCollider>().enabled = enable;
        GetComponent<MeshRenderer>().enabled = enable;
        healthText.gameObject.SetActive(enable);


    }
}
