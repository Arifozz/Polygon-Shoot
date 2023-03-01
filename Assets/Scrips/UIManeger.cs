using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManeger : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI bulletText;
    public TextMeshProUGUI bulletText2;


    public GunShoot gunShoot;
    public GunShoot gunShoot2;


    void Start()
    {
        levelText.text= (SceneManager.GetActiveScene().buildIndex+1).ToString()+"/5";
        
    }


    void Update()
    {
        bulletText.text = "M4A1: "+gunShoot.magazine.ToString();
        bulletText2.text = "Baretta: "+gunShoot2.magazine.ToString();

    }
}
