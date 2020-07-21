using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
