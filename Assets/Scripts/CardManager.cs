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

            if(spriteDecider == 0){
                card.theSprite = sprites[0];
            } else if(spriteDecider == 1){
                card.theSprite = sprites[1];
            } else if(spriteDecider == 2){
                card.theSprite = sprites[2];
            } else if(spriteDecider == 3){
                card.theSprite = sprites[3];
            } else if(spriteDecider == 4){
                card.theSprite = sprites[4];
            } else if(spriteDecider == 5){
                card.theSprite = sprites[5];
            } else if(spriteDecider == 6){
                card.theSprite = sprites[6];
            } else if(spriteDecider == 7){
                card.theSprite = sprites[7];
            } else if(spriteDecider == 8){
                card.theSprite = sprites[8];
            } else if(spriteDecider == 9){
                card.theSprite = sprites[9];
            }

            card.description = "Elemento " + i;
            card.name = "Card " + i;
            cards.Add(card);
        }
        Debug.Log("Listo");
    }
}