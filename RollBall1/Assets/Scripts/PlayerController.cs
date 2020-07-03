using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
     Rigidbody rb;
    private int count;
    public Text countText;
    public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setTextCount();
        winText.text = "";
    }
    private void FixedUpdate()
    {
        float horizental = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vector3 = new Vector3(horizental, 0.0f, vertical);
        rb.AddForce(vector3 * speed);
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setTextCount();
            
        }
        if(count >= 14)
        {
            winText.text = "Conguralation You win the game";
        }

    }
    void setTextCount()
    {
        countText.text = "Total Pick Up:  " + count.ToString();
    }
}

