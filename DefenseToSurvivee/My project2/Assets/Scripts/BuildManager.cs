using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager main;

    [Header("References")]
    //[SerializeField] private GameObject[] characterPrefabs;
    [SerializeField] private Tower[] characters;

    private int selectedCharacterIndex = 0;

    private void Awake()
    {
        main = this;
    }

    public Tower GetSelectedCharacter() 
    {
        return characters[selectedCharacterIndex];
    }

    public void SetSelectedCharacter(int characterIndex)
    {
        selectedCharacterIndex= characterIndex;
    }

    public void SelectSpearman() 
    {
        BuildManager.main.SetSelectedCharacter(0);
    }

    public void SelectArcher()
    {
        BuildManager.main.SetSelectedCharacter(1);
    }

    public void SelectSorcerer()
    {
        BuildManager.main.SetSelectedCharacter(2);
    }

}
