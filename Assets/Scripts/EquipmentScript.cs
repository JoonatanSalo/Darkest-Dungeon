using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentScript : MonoBehaviour
{
    PlayerInfo playerInfo;
    public GameObject inventory;
    InventoryScript inventoryScript;

    public List<Button> MainhandSlots = new List<Button>();
    public List<Button> offhandSlots = new List<Button>();
    public List<Button> armourSlots = new List<Button>();
    public List<Button> ringSlots = new List<Button>();
    public List<Button> consumableSlots = new List<Button>();
    public List<Button> miscSlots = new List<Button>();

    void Start()
    {
        playerInfo = GameObject.FindWithTag("Player").GetComponent<PlayerInfo>();
        inventoryScript = inventory.GetComponent<InventoryScript>();

        MainhandSlots[0].onClick.AddListener(() => ButtonAction(0,0));
        MainhandSlots[1].onClick.AddListener(() => ButtonAction(0,1));

        offhandSlots[0].onClick.AddListener(() => ButtonAction(1, 0));
        offhandSlots[1].onClick.AddListener(() => ButtonAction(1, 1));

        armourSlots[0].onClick.AddListener(() => ButtonAction(2, 0));
        armourSlots[1].onClick.AddListener(() => ButtonAction(2, 1));
        armourSlots[2].onClick.AddListener(() => ButtonAction(2, 2));
        armourSlots[3].onClick.AddListener(() => ButtonAction(2, 3));

        ringSlots[0].onClick.AddListener(() => ButtonAction(3, 0));
        ringSlots[1].onClick.AddListener(() => ButtonAction(3, 1));
        ringSlots[2].onClick.AddListener(() => ButtonAction(3, 2));
        ringSlots[3].onClick.AddListener(() => ButtonAction(3, 3));

        consumableSlots[0].onClick.AddListener(() => ButtonAction(4, 0));
        consumableSlots[1].onClick.AddListener(() => ButtonAction(4, 1));
        consumableSlots[2].onClick.AddListener(() => ButtonAction(4, 2));
        consumableSlots[3].onClick.AddListener(() => ButtonAction(4, 3));

        miscSlots[0].onClick.AddListener(() => ButtonAction(5, 0));
        miscSlots[1].onClick.AddListener(() => ButtonAction(5, 1));
        miscSlots[2].onClick.AddListener(() => ButtonAction(5, 2));
    }

    void ButtonAction(int itemSlot, int InventoryIndex)
    {
        playerInfo.chooseSlot(itemSlot, InventoryIndex);
        inventoryScript.DrawInventory();
    }

    public void DrawScreen ()
    {
        for (int i = 0; i < playerInfo.MainHand.Count; i++)
        {
            //MainhandSlots[i].image.sprite = playerInfo.MainHand[i].GetComponent<WeaponDisplay>().weapon.weapon_artwork;
        }

    }
}
