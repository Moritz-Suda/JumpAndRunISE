using UnityEngine;
using UnityEngine.UI;

public class GlobalEmeralds : MonoBehaviour
{
	public static int EmeraldCount;
  public Text EmeraldDisplay;

  public int InternalEmerald;
  
	// Update is called once per frame
	void Update()
	{
		InternalEmerald = EmeraldCount;
		EmeraldDisplay.text = "Emeralds: " + EmeraldCount;
	}
}
