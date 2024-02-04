using UnityEngine;

public class Emerald : MonoBehaviour
{
  int coinValue = 1;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    ScoreManager.score = coinValue++;
  }

  void OnTriggerEnter(Collider other)
  {
    coinValue = ScoreManager.score;
    Debug.Log("The " + other.gameObject.tag + " has the score " + coinValue);
    Destroy(gameObject);
  }


}
