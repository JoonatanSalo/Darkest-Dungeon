using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryRightClick : MonoBehaviour
{
    /*

    PlayerInfo playerInfo;
    public GameObject weaponInfo;
    WeaponInfo weaponinfo;

    void Start()
    {
        playerInfo = GameObject.FindWithTag("Player").GetComponent<PlayerInfo>();
        weaponinfo = weaponInfo.GetComponent<WeaponInfo>();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Right)
        {
            switch (name)
            {
                case "Item0":
                    if (playerInfo.isEmpty(0)) break;
                    else SetWeapon(0);
                    break;

                case "Item1":
                    if (playerInfo.isEmpty(1)) break;
                    else SetWeapon(1);
                    break;

                case "Item2":
                    if (playerInfo.isEmpty(2)) break;
                    else SetWeapon(2);
                    break;

                case "Item3":
                    if (playerInfo.isEmpty(3)) break;
                    else SetWeapon(3);
                    break;

                case "Item4":
                    if (playerInfo.isEmpty(4)) break;
                    else SetWeapon(4);
                    break;
            }
        }
    }

    public void SetWeapon(int weaponIndex)
    {
        weaponinfo.Weapon_Image.sprite = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.weapon_artwork;

        weaponinfo.baseDMG.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.baseDamage.ToString();
        weaponinfo.level.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.weaponLevel.ToString();
        weaponinfo.fatique.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.fatique.ToString();
        weaponinfo.weaponName.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.weaponName.ToString();

        weaponinfo.requiredSTR.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.strenghtScaling.ToString();
        weaponinfo.requiredDEX.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.dexterityScaling.ToString();
        weaponinfo.requiredINT.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.intelligenceScaling.ToString();

        weaponinfo.scalingSTR.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.strenghtRequirements.ToString();
        weaponinfo.scalingDEX.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.dexterityRequirements.ToString();
        weaponinfo.scalingINT.text = playerInfo.Temporary[weaponIndex].GetComponent<WeaponDisplay>().weapon.intelligenceRequirements.ToString();
    }
    */
}
