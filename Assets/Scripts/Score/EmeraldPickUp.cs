using System.Collections.Generic;
using UnityEngine;

public class EmeraldPickUp : MonoBehaviour
{
  public AudioSource EmeraldAudio;
  
  public static Dictionary<int, bool> pickedUpEmeralds;
  private static int IDCounter = 0;
  public int EmeraldID = -1;
  
  public void Reset()
  { 
    // After you first add this script, run Reset on every coin; when creating new coins it should assign new numbers as you create them
    EmeraldID = IDCounter;
    IDCounter++;
  }

  public void Awake()
  {
    if(pickedUpEmeralds == null)
    {
            pickedUpEmeralds = new Dictionary<int, bool>();
    }
  }

  public void Start()
  {
     Debug.Log("Current Emeralds Count: " + pickedUpEmeralds.Count);

    if (pickedUpEmeralds.ContainsKey(EmeraldID))
    {
      // We're reloading the scene
      if (pickedUpEmeralds[EmeraldID])
      {
        // We've been collected already, so destroy ourself
        Destroy(gameObject);
      }
    }
    else
    {
      pickedUpEmeralds.Add(EmeraldID, false);
      //Reset();
    }
  }

  void OnTriggerEnter(Collider col)
  {  
    if(col.gameObject.tag == "Player")
    {
      //transform.position = new Vector3(0, -1000, 0);
      EmeraldAudio = GameObject.Find("Emerald_Sound").GetComponent<AudioSource>();
      if (EmeraldAudio != null & EmeraldAudio.enabled)
      {
        EmeraldAudio.Play();
        Debug.Log("Played Emerald Sound");
      }
      
      GlobalEmeralds.EmeraldCount += 1;
      pickedUpEmeralds[EmeraldID] = true;
      // Emerald has 10 Points
      GlobalScore.CurrentScore += 10;
      Debug.Log("Added Emerald with ID: " + GetInstanceID());
      Destroy(gameObject);
    }
  }

}
