using System.Collections.Generic;
using TeenPatti.Card;
using TeenPatti.Core;
using TeenPatti.GameLoop;
using TeenPatti.Utilities;
using UnityEngine;
using UnityEngine.UI;

public class GameService : GenericMonoSingleton<GameService>
{
    [Header("Player 1 Card Images")]
    [SerializeField] private Image[] p1CardImages;

    [Header("Player 2 Card Images")]
    [SerializeField] private Image[] p2CardImages;

    [Header("Player1Won UI Panel")]
    [SerializeField] private GameObject player1WonPanel;

    [Header("Player2Won UI Panel")]
    [SerializeField] private GameObject player2WonPanel;

    [SerializeField] private CardSO cardSO;

    private CardService cardService;
    private GameLoopService gameLoopService;

    private List<CardModel> p1Cards = new List<CardModel>();
    private List<CardModel> p2Cards = new List<CardModel>();

    private WinHierarcy winHierarcy;

    private void Start()
    {
        cardService = new CardService(cardSO);
        gameLoopService = new GameLoopService(cardService);
        gameLoopService.StartGameLoop();
        gameLoopService.CheckForWinner();
    }

    private void Update() => gameLoopService.TickUpdate();

    public void InitializePlayerCards()
    {
        for (int i = 0; i < 3; i++)
        {
            p1Cards.Add(cardService.InitializeCard());
            p2Cards.Add(cardService.InitializeCard());

            p1CardImages[i].sprite = p1Cards[i].Image;
            p2CardImages[i].sprite = p2Cards[i].Image;
        }
    }

    public void CheckForWinner()
    {
        // Placeholder for winner checking logic
        Debug.Log("Checking for winner...");

        if (CheckForTriple()) player1WonPanel.SetActive(true);
        else player2WonPanel.SetActive(true);

        if (CheckForPureSequence()) player1WonPanel.SetActive(true);
        else player2WonPanel.SetActive(true);

        if (CheckForSequence()) player1WonPanel.SetActive(true);
        else player2WonPanel.SetActive(true);

        if (CheckForFlush()) player1WonPanel.SetActive(true);
        else player2WonPanel.SetActive(true);

        if (CheckForPair()) player1WonPanel.SetActive(true);
        else player2WonPanel.SetActive(true);

        if (CheckForHighCard()) player1WonPanel.SetActive(true);
        else player2WonPanel.SetActive(true);
    }

    private void CheckHigherHand(List<CardModel> cards)
    {
        int hand = 0;
        if (CheckForHighCard())
            hand++;
    }

    private bool CheckForTriple()
    {
        if (p1Cards[0].Name == p1Cards[1].Name && p1Cards[1].Name == p1Cards[2].Name) return true;

        else if (p2Cards[0].Name == p2Cards[1].Name && p2Cards[1].Name == p2Cards[2].Name) return true;

        else return false;
    }

    private bool CheckForPureSequence()
    {
        bool isP1PureSequence = (p1Cards[0].House == p1Cards[1].House) && (p1Cards[1].House == p1Cards[2].House) &&
                               (int)p1Cards[0].Number + 1 == (int)p1Cards[1].Number &&
                               (int)p1Cards[1].Number + 1 == (int)p1Cards[2].Number;
        bool isP2PureSequence = (p2Cards[0].House == p2Cards[1].House) && (p2Cards[1].House == p2Cards[2].House) &&
                               (int)p2Cards[0].Number + 1 == (int)p2Cards[1].Number &&
                               (int)p2Cards[1].Number + 1 == (int)p2Cards[2].Number;
        return isP1PureSequence || isP2PureSequence;
    }

    private bool CheckForSequence()
    {
        bool isP1Sequence = (int)p1Cards[0].Number + 1 == (int)p1Cards[1].Number &&
                           (int)p1Cards[1].Number + 1 == (int)p1Cards[2].Number;
        bool isP2Sequence = (int)p2Cards[0].Number + 1 == (int)p2Cards[1].Number &&
                           (int)p2Cards[1].Number + 1 == (int)p2Cards[2].Number;
        return isP1Sequence || isP2Sequence;
    }

    private bool CheckForFlush()
    {
        bool isP1Flush = (p1Cards[0].House == p1Cards[1].House) && (p1Cards[1].House == p1Cards[2].House);
        bool isP2Flush = (p2Cards[0].House == p2Cards[1].House) && (p2Cards[1].House == p2Cards[2].House);
        return isP1Flush || isP2Flush;
    }

    private bool CheckForPair()
    {
        bool isP1Pair = (p1Cards[0].Name == p1Cards[1].Name) || (p1Cards[1].Name == p1Cards[2].Name) || (p1Cards[0].Name == p1Cards[2].Name);
        bool isP2Pair = (p2Cards[0].Name == p2Cards[1].Name) || (p2Cards[1].Name == p2Cards[2].Name) || (p2Cards[0].Name == p2Cards[2].Name);
        return isP1Pair || isP2Pair;
    }

    private bool CheckForHighCard()
    {
        bool isP1HighCard = (p1Cards[0].Number > p1Cards[1].Number && p1Cards[1].Number > p1Cards[2].Number);
        bool isP2HighCard = (p2Cards[0].Number > p2Cards[1].Number && p2Cards[1].Number > p2Cards[2].Number);
        return isP1HighCard || isP2HighCard;
    }
}
