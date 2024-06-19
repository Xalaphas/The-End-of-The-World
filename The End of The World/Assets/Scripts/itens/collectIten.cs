using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectIten : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject Collected;
    public int Score;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            Collected.SetActive(true);

            gameController.instance.AddApple(Score);

            Destroy(gameObject, 0.26f);
        }
    }
}
