using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    PlayerInfo playerInfo;

    public Button mainHand;
   // public Button offHand;

    public Text healthText;
    public Text staminaText;
    public Text manaText;

    int playerHealth;
    int currentHealth;

    int playerStamina;
    int currentStamina;

    int playerMana;
    int currentMana;


    void Start()
    {
        playerInfo = GameObject.FindWithTag("Player").GetComponent<PlayerInfo>();

        playerHealth = 10 + 3 * playerInfo.Vitality;
        currentHealth = playerHealth;

        playerStamina = playerInfo.Endurance;
        currentStamina = playerStamina;

        playerMana = playerInfo.Intelligence;
        currentMana = playerMana;


        //mainHand.image.sprite = playerInfo.MainHand[0].GetComponent<WeaponDisplay>().weapon.weapon_artwork;
        //offHand.image.sprite = playerInfo.OffHand[0].GetComponent<CardDisplay>().card.card_artwork;

        SetStats();
    }

    public void Health(int amount)
    {
        currentHealth += amount;

        if (currentHealth <= 0) Die();
    }

    public void Stamina(int amount)
    {
        currentStamina += amount;
    }

    public void Mana(int amount)
    {
        currentStamina += amount;
    }

    public void SetStats()
    {
        healthText.text = currentHealth.ToString();
        staminaText.text = currentStamina.ToString();
        manaText.text = currentMana.ToString();
    }

    public void Die()
    {
        Debug.Log("You died!");
    }

}
