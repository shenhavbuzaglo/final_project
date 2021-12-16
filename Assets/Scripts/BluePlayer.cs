using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BluePlayer : MonoBehaviour
{
    public int blueKeys = 0;
    public float speed = 5.0f;

    public Text blueKeyAmount;
    public Text youWin;
    public GameObject door;


    void Start()
    {
        //Starting Position of blue player
        transform.position = new Vector3(-0.13f, -0.07f, 1f);
    }


    void Update()
    {
        //Blue Player Controller
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (blueKeys == 3)
        {
            youWin.text = "BLUE PLAYER WINS!!!";
            youWin.gameObject.SetActive(true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Keys")
        {
            blueKeys++;
            blueKeyAmount.text = "Blue Keys: " + blueKeys;
            Destroy(collision.gameObject);
        }

    }
}