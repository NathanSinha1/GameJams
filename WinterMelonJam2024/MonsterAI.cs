using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public string state = "dormant";

    private float distance;

    public void ChangeState(string state)
    {
        this.state = state;
    }
    // Start is called before the first frame update
    void Start()
    {
        state = "dormant";
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        if (state == "chase")
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        else if (state == "retreat")
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, (-2*speed) * Time.deltaTime);
        }
        else if (state == "dormant")
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            ChangeState("retreat");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            ChangeState("chase");
        }
    }
}
