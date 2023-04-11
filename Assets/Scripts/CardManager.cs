using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> cards;
    public List<Sprite> sprites;

    private int spriteDecider;


    private void Awake()
    {
        cards = new List<Card>();

        // Agrega 10 cartas a la lista
        for (int i = 0; i < 10; i++)
        {
            Card card = ScriptableObject.CreateInstance<Card>();
            card.attack = Random.Range(10, 100);
            card.health = Random.Range(10, 100);
            card.value = Random.Range(10, 100);
            spriteDecider = Random.Range(0,10);

            if(spriteDecider > 0 && spriteDecider < 5)
            {
                card.theSprite = sprites[0];
            } else
            {
                card.theSprite = sprites[1];
            }

            card.description = "Elemento " + i;
            card.name = "Card " + i;
            cards.Add(card);
        }
        Debug.Log("Listo");
    }
}