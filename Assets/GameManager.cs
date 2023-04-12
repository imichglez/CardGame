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
        GameObject[] cardPrefabs = new GameObject[selectedCards.Count];
        for (int i = 0; i < selectedCards.Count; i++)
        {
            GameObject cardGO = Instantiate(cardPrefab, transform);
            cardGO.transform.position = GetCardPosition(i);
            CardPrefab cardPrefabComponent = cardGO.GetComponent<CardPrefab>();
            cardPrefabComponent.SetCard(selectedCards[i]);
            cardPrefabs[i] = cardGO;
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
        for (int i = 0; i < cardPrefabs.Length && i < selectedCards.Count; i++)
        {
            cardPrefabs[i].SetCard(selectedCards[i]);
        }
        Debug.Log("Shuffle");
    }

    // Retorna la posición en la que debe aparecer la carta con el índice especificado
    private Vector3 GetCardPosition(int index)
    {
        switch (index)
        {
            case 0:
                return new Vector3(-7.89f, 0.92f, 0f);
            case 1:
                return new Vector3(-3.81f, 0.92f, 0f);
            case 2:
                return new Vector3(0.2f, 0.92f, 0f);
            case 3:
                return new Vector3(7.97f, 0.92f, 0f);
            case 4:
                return new Vector3(4.12f, 0.92f, 0f);
            default:
                return Vector3.zero;
        }
    }
}