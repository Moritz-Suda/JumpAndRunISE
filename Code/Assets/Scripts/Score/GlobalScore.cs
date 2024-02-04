using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
	public static int CurrentScore;
	public int InternalScore;
	public Text ScoreDisplay;

	void Update()
	{
		InternalScore = CurrentScore;
		ScoreDisplay.GetComponent<Text>().text = "Score: " + InternalScore;
	}
}
