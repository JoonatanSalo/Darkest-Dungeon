using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        enemyLevel = 1;
    }

    public List<PlayerClass> classes = new List<PlayerClass>();

    public PlayerClass playerClass;

    public Player player;

    public int enemyLevel;

    public int Vitality;
    public int Strenght;
    public int Endurance;
    public int Intelligence;
    public int Dexterity;


    public void ChooseClass(int index)
    {
        playerClass = classes[index];
        player = new Player(playerClass);


    }

    public List<GameObject> HandHeldInventory = new List<GameObject>();
    public List<GameObject> ArmourInventory = new List<GameObject>();
    public List<GameObject> RingInventory = new List<GameObject>();
    public List<GameObject> ConsumableInventory = new List<GameObject>();
    public List<GameObject> MiscInventory = new List<GameObject>();

    public enum ItemType
    {
        Handheld,
        Armour,
        Ring,
        Consumable,
        Misc
    }

    public void GainItem (ItemType type, GameObject item)
    {
        switch (type)
        {
            case ItemType.Handheld:
                HandHeldInventory.Add(item);
                break;

            case ItemType.Armour:
                ArmourInventory.Add(item);
                break;

            case ItemType.Ring:
                RingInventory.Add(item);
                break;

            case ItemType.Consumable:
                ConsumableInventory.Add(item);
                break;

            case ItemType.Misc:
                MiscInventory.Add(item);
                break;
        }
    }

    public enum ItemSlots
    {
        MainHand,
        OffHand,
        Armour,
        Rings,
        Consumable,
        Misc
    }

    ItemSlots chosenSlot;

    public List<GameObject> MainHand = new List<GameObject>();
    public List<GameObject> OffHand = new List<GameObject>();
    public List<GameObject> Armour = new List<GameObject>();
    public List<GameObject> Rings = new List<GameObject>();
    public List<GameObject> Consumable = new List<GameObject>();
    public List<GameObject> Misc = new List<GameObject>();

    public List<GameObject> Temporary = new List<GameObject>();

    int chosenIndex;

    public void chooseSlot(int slot, int SlotIndex)
    {
        chosenSlot = (ItemSlots)slot;
        chosenIndex = SlotIndex;

        switch (chosenSlot)
        {
            case ItemSlots.MainHand:
                Temporary = HandHeldInventory;
                break;

            case ItemSlots.OffHand:
                Temporary = HandHeldInventory;
                break;

            case ItemSlots.Armour:
                Temporary = ArmourInventory;
                break;

            case ItemSlots.Rings:
                Temporary = RingInventory;
                break;

            case ItemSlots.Consumable:
                Temporary = ConsumableInventory;
                break;

            case ItemSlots.Misc:
                Temporary = MiscInventory;
                break;
        }
    }

    public bool isEmpty (int EmptyIndex)
    {
        if (EmptyIndex + 1 > Temporary.Count)
        {
            Debug.Log("Slot Empty");
            return true;
        }
        else return false;
    }

    public void Equip(int EquipIndex)
    {
        switch (chosenSlot)
        {
            case ItemSlots.MainHand:
                MainHand.Add(Temporary[EquipIndex]);
                
                break;

            case ItemSlots.OffHand:
                OffHand.Add(Temporary[EquipIndex]);
                
                break;

            case ItemSlots.Armour:
                Armour.Add(Temporary[EquipIndex]);
                
                break;

            case ItemSlots.Rings:
                Rings.Add(Temporary[EquipIndex]);
                
                break;

            case ItemSlots.Consumable:
                Consumable.Add(Temporary[EquipIndex]);
                
                break;

            case ItemSlots.Misc:
                Misc.Add(Temporary[EquipIndex]);
                
                break;
        }
        GameObject.FindGameObjectWithTag("Equipment").GetComponent<EquipmentScript>().DrawScreen();
    }




    private int playerLevel = 1;
    int expNeeded = 100;

    private int playerTokens = 0;

    public void GainExp(int exp)
    {
        if (exp > expNeeded)
        {
            expNeeded -= exp;
            playerLevel += 1;
        }
        else
            expNeeded -= exp;
    }

    public void GainTokens(int tokens)
    {
        playerTokens += tokens;
    }

   

}
