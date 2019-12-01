
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float speed;
   
    
    void Update()
    {
        this.transform.RotateAround(this.transform.parent.position,this.transform.parent.up,speed*Time.deltaTime);
    }
}
