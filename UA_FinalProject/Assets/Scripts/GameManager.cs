using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] cards;
    public CardSO[] cardSOs;

    void Start()
    {
        RandomizeCards();
    }

    public void RandomizeCards()
    { 
        int randomCardIndex;

        for(int i = 0; i<cards.Length; i++)
        {
            randomCardIndex = Random.Range(0, cardSOs.Length);
            cards[i].gameObject.GetComponent<Card>().cardSO = cardSOs[randomCardIndex];
        }

        for (int i = 0; i < cards.Length; i++)
        {
            cards[i].gameObject.SetActive(false);
            cards[i].gameObject.SetActive(true);
        }
    }
}
