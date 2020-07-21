using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingWeaponSelection : MonoBehaviour
{
    public List<GameObject> starterWeapons = new List<GameObject>();

    public void PickStarterWeapon (int index)
    {
        if (starterWeapons[index] == null) return;
        GameObject.FindWithTag("Player").GetComponent<PlayerInfo>().HandHeldInventory.Add(starterWeapons[index]);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("FightPrep");
    }
}
