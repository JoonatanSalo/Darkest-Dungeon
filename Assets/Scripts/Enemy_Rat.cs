using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Rat : MonoBehaviour
{
    PlayerInfo playerInfo;
    Enemy enemy;

    void Start()
    {
        playerInfo = GameObject.FindWithTag("Player").GetComponent<PlayerInfo>();
        enemy = GetComponent<Enemy>();

        int enemyLevel = playerInfo.enemyLevel;
        int maxHealth = 15 + enemyLevel * 5;
        int attackValue = 2 + enemyLevel * 1;
        int armour = 0;
        int magicResist = 0;

        enemy.SetStats(enemyLevel, maxHealth, attackValue, armour, magicResist);
    }
}
