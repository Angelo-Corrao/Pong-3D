using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text player1ScoreText;
	public Text player2ScoreText;
	private int player1Score;
    private int player2Score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1Scores() {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        ball.ResetPosition();
        ball.AddStartingForce();

	}

	public void Player2Scores() {
        player2Score++;
		player2ScoreText.text = player2Score.ToString();
		ball.ResetPosition();
		ball.AddStartingForce();
	}
}
