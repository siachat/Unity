using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scoreText : GM
{
     public Transform player;
    public Transform startObject;
    public Transform finishObject;
    public TMPro.TMP_Text sText;
    int score = 0;
    int distanceToFinish;

    void Start() {

      Scene scene = SceneManager.GetActiveScene();
        
    }

    // Update is called once per frame
    void Update()
    {
        score = Mathf.FloorToInt(player.transform.position.z - startObject.transform.position.z);        
        distanceToFinish = Mathf.FloorToInt(finishObject.transform.position.z - player.transform.position.z);  
        if (distanceToFinish == 0) base.EndLevel();
        sText.text = "Score: " + score.ToString();
      
    }
}
