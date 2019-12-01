using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public float Velocidadimpulso;
    public float speed;

    private int coldown;
    private int count;

    public Text countText;
    public Text winText;
    public Text Coldown;

    
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        coldown = 0;
        

    }

    void FixedUpdate() {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        

        rb.AddForce(movement*speed);

        if (Input.GetKey(KeyCode.Q) && coldown <= 0) {
            rb.AddForce(movement*Velocidadimpulso*speed);
            coldown = 180;
            SetColdown();

            
        }
        if (coldown > 0)
        {
            coldown--;
            SetColdown();
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {

            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count>=5) {
            winText.text ="  YOU WIN!";
        }
    }

    void SetColdown() {
        Coldown.text = "Coldown: " + coldown.ToString();
    }
}
