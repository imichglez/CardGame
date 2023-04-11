using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public Sprite theSprite;
    public string description;
    public int health;
    public int attack;
    public int value;
}
