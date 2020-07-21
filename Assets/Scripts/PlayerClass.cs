using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Class", menuName = "Class")]
public class PlayerClass : ScriptableObject
{
    public enum CharacterClasses
    {
        Knight = 0,
        Mage = 1,
        Alchemist = 2,
        Bishop = 3
    }

    //public List<Card> starterInventory = new List<Card>();

    public CharacterClasses characterClass;

    public int vitality;
    public int strenght;
    public int endurance;
    public int intelligence;
    public int dexterity;
}