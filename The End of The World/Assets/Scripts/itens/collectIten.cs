using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectIten : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;

    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

     void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player") {
            sr.enabled = true;
            circle.enabled = true;
            collected.SetActive(true);  
            
            gameController.instance.totalScore += Score;
            gameController.instance.UpdataScoreText();

            Destroy(gameObject, 0.26f);
        }
    }
}
