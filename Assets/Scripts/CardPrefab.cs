using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardPrefab : MonoBehaviour
{
    public Card card;
    public SpriteRenderer cardImage;
    public TMP_Text cardName;
    public TMP_Text cardAttack;
    public TMP_Text cardHealth;
    public TMP_Text cardValue;
    public TMP_Text cardDescription;

    public void SetCard(Card card)
    {
        this.card = card;
        cardImage.sprite = card.theSprite;
        cardName.text = card.name;
        cardAttack.text = card.attack.ToString();
        cardHealth.text = card.health.ToString();
        cardValue.text = card.value.ToString();
        cardDescription.text = card.description;
    }
}