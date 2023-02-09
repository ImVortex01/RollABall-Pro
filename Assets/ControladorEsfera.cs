using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControladorEsfera : MonoBehaviour
{
    public float speed;
    private int count;
    public TextMeshPro mtext;

    void Start() {
        count = 0;
        UpdateCounter();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        GetComponent<Rigidbody>().AddForce(direction * speed);
    }
     void OnTriggerEnter(Collider other) {
        if(other.tag == "pickup"){
            Destroy(other.gameObject);
            count++;
            UpdateCounter();
        }       
    }
    void UpdateCounter(){
        mtext.text = "Puntuacion: " + count;
    }
}
