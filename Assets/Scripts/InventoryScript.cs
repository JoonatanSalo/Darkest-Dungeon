using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryScript : MonoBehaviour
{
    PlayerInfo playerInfo;

    public Sprite Empty;
 
    public List<Button> items = new List<Button>();

    void Start()
    {
        playerInfo = GameObject.FindWithTag("Player").GetComponent<PlayerInfo>();

        for (int i = 0; i < items.Count; i++)
        {
            items[i].onClick.AddListener(() => ButtonAction(i));
        }

        DrawInventory();
    }

    void ButtonAction(int EquipmentIndex)
    {
        if (playerInfo.isEmpty(EquipmentIndex)) return;

        playerInfo.Equip(EquipmentIndex);
    }

    //public Sprite GetCardImage(int inventoryIndex)
    //{
        //return playerInfo.Temporary[inventoryIndex].GetComponent<WeaponDisplay>().weapon.weapon_artwork;
    //}

    public void DrawInventory()
    {
        for (int i = 0; i < items.Count; i++)
        {
            items[i].image.sprite = Empty;
        }

        for (int i = 0; i < playerInfo.Temporary.Count; i++)
        {
            //items[i].image.sprite = GetCardImage(i);
        }
    }
}
