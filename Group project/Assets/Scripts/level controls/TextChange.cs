using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text reserveAmmoText;

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health : " + Player.currentHealth;
        reserveAmmoText.text = "Reserve Ammo : " + Musket.currentAmmo;
        //loadedAmmoText.text = "Loaded Ammo : " + Musket.loadedAmmo;
    }
}
