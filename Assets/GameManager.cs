using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cardPrefab;
    public CardManager cardManager;

    private void Start()
    {
        List<Card> cards = cardManager.cards;

        // Obtiene 5 cartas aleatorias de la lista
        List<Card> selectedCards = new List<Card>();
        for (int i = 0; i < 5; i++)
        {
            Card randomCard = cards[Random.Range(0, cards.Count)];
            selectedCards.Add(randomCard);
        }

        // Instancia 5 prefabs y asigna cada una de las cartas a ellos
        for (int i = 0; i < 5; i++)
        {
            GameObject cardGO = Instantiate(cardPrefab);
            cardGO.transform.SetParent(transform);
            CardPrefab cardPrefabComponent = cardGO.GetComponent<CardPrefab>();
            cardPrefabComponent.SetCard(selectedCards[i]);
        }
    }

    // Método llamado por el botón "aleatorizar"
    public void ShuffleCards()
    {
        // Obtiene 5 cartas aleatorias de la lista
        List<Card> selectedCards = new List<Card>();
        for (int i = 0; i < 5; i++)
        {
            Card randomCard = cardManager.cards[Random.Range(0, cardManager.cards.Count)];
            selectedCards.Add(randomCard);
        }

        // Actualiza las cartas de los prefabs existentes
        CardPrefab[] cardPrefabs = GetComponentsInChildren<CardPrefab>();
        for (int i = 0; i < cardPrefabs.Length; i++)
        {
            cardPrefabs[i].SetCard(selectedCards[i]);
        }
        Debug.Log("Shuffle");
   }
}