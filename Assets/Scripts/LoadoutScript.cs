using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LoadoutScript : MonoBehaviour
{
    PlayerInfo playerInfo;

    void Start()
    {
        playerInfo = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInfo>();
    }

    void ClearInventorySlot (int slot, int index)
    {
        switch (slot)
        {
            case 0:
                playerInfo.HandHeldInventory.Add(playerInfo.MainHand[index]);
                playerInfo.MainHand.RemoveAt(index);
                break;

            case 1:
                playerInfo.HandHeldInventory.Add(playerInfo.OffHand[index]);
                playerInfo.OffHand.RemoveAt(index);
                break;

            case 2:
                playerInfo.ArmourInventory.Add(playerInfo.Armour[index]);
                playerInfo.Armour.RemoveAt(index);
                break;

            case 3:
                playerInfo.RingInventory.Add(playerInfo.Rings[index]);
                playerInfo.Rings.RemoveAt(index);
                break;

            case 4:
                playerInfo.ConsumableInventory.Add(playerInfo.Consumable[index]);
                playerInfo.Consumable.RemoveAt(index);
                break;

            case 5:
                playerInfo.MiscInventory.Add(playerInfo.Misc[index]);
                playerInfo.Misc.RemoveAt(index);
                break;
        }
    }

    public bool isEmpty(int EmptyIndex)
    {
        if (EmptyIndex + 1 > playerInfo.Temporary.Count)
        {
            Debug.Log("Slot Empty");
            return true;
        }
        else return false;
    }

}
