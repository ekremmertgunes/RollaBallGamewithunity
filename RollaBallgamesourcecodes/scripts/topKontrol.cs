using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topKontrol : MonoBehaviour
{
    public int hiz = 1;
    Rigidbody rigidbody_;
    public GameObject sayacText;
    public int sayac = 0;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vector = new Vector3(yatay, 0, dikey);
        rigidbody_.AddForce(vector * hiz);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("topEngel"))
        {
            sayac++;
            sayacText.GetComponent<Text>().text = "Sayac:" + sayac;

            other.gameObject.SetActive(false);

        }
    }
}

