using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

    private GameObject character;
    private Color startColor;

    private void Start()
    {
        startColor = sr.color;
    }

    private void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown()
    {
        if (character != null) return;

        Tower characterToPut = BuildManager.main.GetSelectedCharacter();

        if(characterToPut.cost > LevelManager.main.currency)
        {
            Debug.Log("You can't afford this character");
            return;
        }

        LevelManager.main.SpendCurrency(characterToPut.cost);

        character = Instantiate(characterToPut.prefab, transform.position, Quaternion.identity);
    }

}

