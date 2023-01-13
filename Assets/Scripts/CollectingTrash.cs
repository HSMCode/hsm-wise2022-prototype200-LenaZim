using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingTrash : MonoBehaviour
{
    // Basket
    public GameObject Basket;

    // Counter
    public CollectedCounter Counter;

    public int TrashCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        Basket = GameObject.FindWithTag("Collecter");
        Counter = GameObject.Find("CollectedCounter").GetComponent<CollectedCounter>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collecter"))
        {
            // print to console
            print("Rat collected Trash");

            Destroy(gameObject);

            // update Counter
            Counter.UpdateTrash(TrashCount);
        }
    }
}
