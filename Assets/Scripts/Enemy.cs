using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Text levelText;
    public Text healthText;
    public Text attackText;

    int enemyLevel;

    int enemyMaxHealth;
    int enemyCurrentHealth;

    int enemyAttack;

    int enemyArmour;
    int enemyMagicResist;

    public enum DamageType
    {
        Physical,
        Magical,
        Piercing
    }

    DamageType damageType;

    public void SetStats(int level, int health, int attack, int armour, int magicResist)
    {
        enemyLevel = level;
        enemyMaxHealth = health;
        enemyCurrentHealth = enemyMaxHealth;
        enemyAttack = attack;
        enemyArmour = armour;
        enemyMagicResist = magicResist;

        UpdateStats();
    }

    public void TakeDamage(DamageType type, int amount)
    {
        damageType = type;

        switch (damageType)
        {
            case DamageType.Physical:
                if (amount <= enemyArmour) enemyCurrentHealth -= 1;
                else enemyCurrentHealth -= amount - enemyArmour;

                if (enemyCurrentHealth <= 0) Die();
                break;

            case DamageType.Magical:
                if (amount <= enemyMagicResist) enemyCurrentHealth -= 1;
                else enemyCurrentHealth -= amount - enemyMagicResist;

                if (enemyCurrentHealth <= 0) Die();
                break;

            case DamageType.Piercing:
                enemyCurrentHealth -= amount;

                if (enemyCurrentHealth <= 0) Die();
                break;
        }

        UpdateStats();
    }

    public void UpdateStats()
    {
        levelText.text = enemyLevel.ToString();
        healthText.text = enemyCurrentHealth.ToString();
        attackText.text = enemyAttack.ToString();
    }

    void Die()
    {
        Debug.Log("Enemy Died.");
    }
}
