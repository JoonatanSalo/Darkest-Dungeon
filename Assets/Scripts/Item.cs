using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    
    public enum ItemType
    {
        Weapon = 0,
        Armour = 1,
        Ring = 2,
        Consumable = 3,
        Misc = 4
    }
   
    public ItemType itemType;

    #region generic
    public Sprite artwork;
    public string itemName;
    public string itemDescription;
    public int level;



    #endregion


    #region Weapon
    public enum Scaling
    {
        __,
        B,
        A,
        S
    }

    public enum DamageType
    {
        Physical,
        Magical,
        Piercing
    }

    
    [ConditionalEnumHide("itemType", 0)] public DamageType damageType;
    [ConditionalEnumHide("itemType", 0)] public int baseDamage;
    [ConditionalEnumHide("itemType", 0)] public int fatique;

    
    [ConditionalEnumHide("itemType", 0)] public Scaling strenghtScaling;
    [ConditionalEnumHide("itemType", 0)] public Scaling dexterityScaling;
    [ConditionalEnumHide("itemType", 0)] public Scaling intelligenceScaling;

    
    [ConditionalEnumHide("itemType", 0)] public int strenghtRequirements;
    [ConditionalEnumHide("itemType", 0)] public int dexterityRequirements;
    [ConditionalEnumHide("itemType", 0)] public int intelligenceRequirements;

    #endregion

    #region Armour

    public enum ArmourType
    {
        HeadPiece,
        ChestPiece,
        ArmPiece,
        LegPiece,
        Ring
    }

    
    [ConditionalEnumHide("itemType", 1)] public ArmourType armourType;
    [ConditionalEnumHide("itemType", 1)] public int physicalDef;
    [ConditionalEnumHide("itemType", 1)] public int magicalDef;

    
    [ConditionalEnumHide("itemType", 1)] public int healthBuff;
    [ConditionalEnumHide("itemType", 1)] public int staminaBuff;
    [ConditionalEnumHide("itemType", 1)] public int manaBuff;

    
    [ConditionalEnumHide("itemType", 1)] public int spellDamage;

    #endregion

}
