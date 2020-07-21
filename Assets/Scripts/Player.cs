using System.Collections;
using System.Collections.Generic;

public class Player
{
    public Player(PlayerClass _startingClass)
    {
        playerClass = _startingClass;

        vitality = _startingClass.vitality;
        strenght = _startingClass.strenght;
        endurance = _startingClass.endurance;
        intelligence = _startingClass.intelligence;
        dexterity = _startingClass.dexterity;
    }

   public PlayerClass playerClass;

    public int vitality;
    public int strenght;
    public int endurance;
    public int intelligence;
    public int dexterity;
}
