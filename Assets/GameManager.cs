using UnityEngine;

public class GameManager : MonoBehaviour

{
    public static GameManager Instance;

    [SerializeField] private GameObject ball;

    public int scorePlayer = 0;
    public int scoreAI = 0;
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    public void ScoreAI()
    {
        scoreAI++;
        GameObject ballSpawn = Instantiate(ball, transform.position, transform.rotation);
        ballSpawn.GetComponent<BallController>().didPlayerScore = false;
    }

    public void ScorePlayer()
    {
        scorePlayer++;
        GameObject ballSpawn = Instantiate(ball, transform.position, transform.rotation);
        ballSpawn.GetComponent<BallController>().didPlayerScore = true;
    }
}
