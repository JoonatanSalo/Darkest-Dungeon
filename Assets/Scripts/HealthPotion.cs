using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HealthPotion : MonoBehaviour, IPointerClickHandler
{
    public GameObject healthPotion;
    PlayerCombat player;
    bool track;
    int potionLevel;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            track = !track;
        }
    }

    void ConsumePotion(int level)
    {
        int heal = 5 + level * 5;
        player.Health(heal);
    }

    void Start()
    {
        track = false;
        player = GameObject.FindWithTag("Player").GetComponent<PlayerCombat>();
        //potionLevel = healthPotion.GetComponent<CardDisplay>().card.card_level;
    }

   
    void Update()
    {
        if (track) healthPotion.transform.position = Input.mousePosition;
    }
}
