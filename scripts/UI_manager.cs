using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UI_manager : MonoBehaviour
{
    public Battle_Controller player;
    public Slider healthBar;
    public Slider manaBar;
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI mpText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = player.goesNext.maxHealth;
        healthBar.value = player.goesNext.currentHealth;

        manaBar.maxValue = player.goesNext.maxMana;
        manaBar.value = player.goesNext.currentMana;


        hpText.text = player.goesNext.currentHealth + "/" + player.goesNext.maxHealth;
        mpText.text = player.goesNext.currentMana + "/" + player.goesNext.maxMana;
    }
}
