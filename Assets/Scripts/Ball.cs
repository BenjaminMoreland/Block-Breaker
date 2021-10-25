using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(200f, 200f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<LifeKeeper>().DecreaseLives();
        Destroy(gameObject);
    }
}
