using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RedPlayer : MonoBehaviour
{
    public int redKeys = 0;
    public float speed = 5.0f;

    public Text redKeyAmount;
    public Text youWin;
    public GameObject door;


    void Start()
    {
        //Starting Position of red player
        transform.position = new Vector3(-0.53f, -1.07f, 1f);
    }


    void Update()
    {
        //Red Player Controller
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (redKeys == 3)
        {
            youWin.text = "RED PLAYER WINS!!!";
            youWin.gameObject.SetActive(true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Keys")
        {
            redKeys++;
            redKeyAmount.text = "Red Keys: " + redKeys;
            Destroy(collision.gameObject);
        }

    }
}