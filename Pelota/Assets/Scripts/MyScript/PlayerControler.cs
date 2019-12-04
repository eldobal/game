using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float VelocidadImpulso;
    private int coldown;
    private int tranformacion;
    private int contador;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        coldown = 0;
        tranformacion = 0;
        contador = 0;
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
       
        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        
        
        rb.AddForce(movement *speed);
        //SetColdown();
        

       
        if (Input.GetKey(KeyCode.Q) && coldown<=0)
        {
            rb.AddForce(movement*VelocidadImpulso* speed);
            coldown = 180;
            //SetColdown();
            
        }
        if (coldown>0)
        {
            coldown--;
            //SetColdown();
        }
        if (tranformacion>0)
        {
            tranformacion--;
        }
        if (tranformacion == 0)
        {
           transform.localScale = new Vector3(1, 1, 1);
        }

       

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Destroy(other.gameObject);

           // other.gameObject.SetActive(false);
            transform.localScale = new Vector3(2, 2, 2);
            tranformacion = 300;
           
        }
        if (other.gameObject.CompareTag("Player"))
        {
           Rigidbody rba = other.gameObject.GetComponent<Rigidbody>();
            
           Vector3 mov = rba.position;
            rba.AddForce(mov*20*VelocidadImpulso*speed);

        }
        
    }

    
   

}
