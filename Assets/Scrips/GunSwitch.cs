using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitch : MonoBehaviour
{
    public GameObject[] guns;
    int indexOfGuns;

    private void Start()
    {        
        Switch(0);       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && indexOfGuns!= 0)
        {
            Debug.Log("M4A1 Kullanıyorsunuz!");
            indexOfGuns = 0;
            Switch(indexOfGuns);
        }
        else if (Input.GetKeyDown(KeyCode.W) && indexOfGuns!= 1)
        {
            Debug.Log("Baretta 9mm Kullanıyorsunuz!");
            indexOfGuns = 1;           

            Switch(indexOfGuns);
        }
    }

    void Switch(int number)
    {
       for (int i = 0; i < guns.Length; i++)
       {
            guns[i].SetActive(false);                          
       }
        guns[number].SetActive(true);

    }

}
