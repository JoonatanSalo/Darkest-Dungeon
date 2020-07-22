using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Item item;

    void Start()
    {
        GameObject cardTemplateAsset;

        switch (item.itemType)
        {
            case Item.ItemType.Weapon:
                cardTemplateAsset = (GameObject)Resources.Load("ItemDisplays/Weapon");
                break;

            case Item.ItemType.Armour:
                cardTemplateAsset = (GameObject)Resources.Load("ItemDisplays/Armour");
                break;

            case Item.ItemType.Ring:
                cardTemplateAsset = (GameObject)Resources.Load("ItemDisplays/Card");
                break;

            case Item.ItemType.Consumable:
                cardTemplateAsset = (GameObject)Resources.Load("ItemDisplays/Card");
                break;

            case Item.ItemType.Misc:
                cardTemplateAsset = (GameObject)Resources.Load("ItemDisplays/Card");
                break;

            default:
                cardTemplateAsset = (GameObject)Resources.Load("ItemDisplays/Card");
                break;
        }

        var cardDisplay = Instantiate(cardTemplateAsset, transform);

        cardDisplay.transform.GetChild(0).GetComponent<Image>().sprite = item.artwork;
        cardDisplay.transform.GetChild(2).GetComponent<Text>().text = item.itemName;
        cardDisplay.transform.GetChild(3).GetComponent<Text>().text = item.level.ToString();

        switch (item.itemType)
        {
            case Item.ItemType.Weapon:
                cardDisplay.transform.GetChild(4).GetComponent<Text>().text = item.baseDamage.ToString();
                cardDisplay.transform.GetChild(5).GetComponent<Text>().text = item.fatique.ToString();

                cardDisplay.transform.GetChild(6).GetComponent<Text>().text = item.strenghtScaling.ToString();
                cardDisplay.transform.GetChild(7).GetComponent<Text>().text = item.dexterityScaling.ToString();
                cardDisplay.transform.GetChild(8).GetComponent<Text>().text = item.intelligenceScaling.ToString();

                cardDisplay.transform.GetChild(9).GetComponent<Text>().text = item.strenghtRequirements.ToString();
                cardDisplay.transform.GetChild(10).GetComponent<Text>().text = item.dexterityRequirements.ToString();
                cardDisplay.transform.GetChild(11).GetComponent<Text>().text = item.intelligenceRequirements.ToString();
                break;

            case Item.ItemType.Armour:
                cardDisplay.transform.GetChild(4).GetComponent<Text>().text = item.physicalDef.ToString();
                cardDisplay.transform.GetChild(5).GetComponent<Text>().text = item.magicalDef.ToString();

                cardDisplay.transform.GetChild(6).GetComponent<Text>().text = item.healthBuff.ToString();
                cardDisplay.transform.GetChild(7).GetComponent<Text>().text = item.staminaBuff.ToString();
                cardDisplay.transform.GetChild(8).GetComponent<Text>().text = item.manaBuff.ToString();
                cardDisplay.transform.GetChild(9).GetComponent<Text>().text = item.spellDamage.ToString();
                break;

            case Item.ItemType.Ring:
                cardDisplay.transform.GetChild(4).GetComponent<Text>().text = item.itemDescription;
                break;

            case Item.ItemType.Consumable:
                cardDisplay.transform.GetChild(4).GetComponent<Text>().text = item.itemDescription;
                break;

            case Item.ItemType.Misc:
                cardDisplay.transform.GetChild(4).GetComponent<Text>().text = item.itemDescription;
                break;

            default:
                cardDisplay.transform.GetChild(4).GetComponent<Text>().text = item.itemDescription;
                break;
        }
    }

    
    void Update()
    {
        
    }
}
