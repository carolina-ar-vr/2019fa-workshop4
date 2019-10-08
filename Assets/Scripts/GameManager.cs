using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    // Editor settings
    [SerializeField] private float gameDuration = 30f;
    [SerializeField] private UnityEvent onGameStart;
    [SerializeField] private UnityEvent onGameEnd;

    // State API
    public int Score { get; private set; }
    public float TimeLeft { get; private set; }
    public bool InProgress { get { return TimeLeft > 0; } }
    public float GameProgress { get { return InProgress ? (gameDuration - TimeLeft) / gameDuration : 0; } }

    // Singleton Reference
    public static GameManager Instance { get; private set; }
    // Unity calls
    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (InProgress)
        {
            TimeLeft = Mathf.Max(0, TimeLeft -= Time.deltaTime);

            if (!InProgress) {
                onGameEnd.Invoke();
            }
        }
    }

    // Action API
    public void StartGame()
    {
        TimeLeft = gameDuration;
        Score = 0;

        onGameStart.Invoke();
    }

    public void AddPoints(int points)
    {
        if (InProgress) {
            Score += points;
        }
    }
}
