using UnityEngine;
using UnityEngine.SceneManagement;

public class MessageOnCollision : MonoBehaviour
{
    public GameObject spawner;

    public Color triggerColor;

    private Color _originalColor;

    public int  namelevel;

    void Start()
    {
        _originalColor = GetComponent<SpriteRenderer>().color;
    }

    void OnTriggerEnter2D(Collider2D o)
    {
        GetComponent<SpriteRenderer>().color = triggerColor;
        Debug.Log(gameObject.name + " OnTriggerEnter with " + o.name);
    if (o.GetComponent<PlayerController2D>())
        {
            if (spawner)
            {
                o.transform.position = spawner.transform.position;
            }
            else
            {
                SceneManager.LoadScene(namelevel);
            }
        }
    }

    void OnTriggerStay2D(Collider2D o)
    {
        GetComponent<SpriteRenderer>().color = triggerColor;
        Debug.Log(gameObject.name + " OnTriggerStay with " + o.name);
    }

    void OnTriggerExit2D(Collider2D o)
    {
        GetComponent<SpriteRenderer>().color = _originalColor;
        Debug.Log(gameObject.name + " OnTriggerExit with " + o.name);
    }

    void OnCollisionEnter2D(Collision2D o)
    {
        Debug.Log(gameObject.name + " OnCollisionEnter with " + o.collider.name);
    }

    void OnCollisionStay2D(Collision2D o)
    {
        Debug.Log(gameObject.name + " OnCollisionStay with " + o.collider.name);
    }

    void OnCollisionExit2D(Collision2D o)
    {
        Debug.Log(gameObject.name + " OnCollisionExit with " + o.collider.name);
    }

}
