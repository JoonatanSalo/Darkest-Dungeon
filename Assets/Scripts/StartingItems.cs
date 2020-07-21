using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingItems : MonoBehaviour
{
    PlayerInfo playerInfo;

    private void Start()
    {
        playerInfo = GameObject.FindWithTag("Player").GetComponent<PlayerInfo>();
    }

    private List<GameObject> list = new List<GameObject>();

    public List<GameObject> KnightStarter = new List<GameObject>();
    public List<GameObject> MageStarter = new List<GameObject>();


    public void GainStarterItems(int num)
    {
        switch (num)
        {
            case 0:
                list = KnightStarter;
                break;

            case 1:
                list = MageStarter;
                break;
        }


        for (int i = 0; i < list.Count; i++)
        {
            /*string itemType = list[i].GetComponent<CardDisplay>().card.itemType.ToString();

            switch (itemType)
            {
                case "Handheld":
                    playerInfo.HandHeldInventory.Add(list[i]);
                    break;

                case "Armour":
                    playerInfo.ArmourInventory.Add(list[i]);
                    break;

                case "Ring":
                    playerInfo.RingInventory.Add(list[i]);
                    break;

                case "Consumable":
                    playerInfo.ConsumableInventory.Add(list[i]);
                    break;

                case "Misc":
                    playerInfo.MiscInventory.Add(list[i]);
                    break;
            }
            */
        }
    }
}
