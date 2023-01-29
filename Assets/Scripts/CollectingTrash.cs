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

    // for on pizza
    private bool isOnPizza = false;

    private Rigidbody _rb;

    public AudioClip trashSFX;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Basket = GameObject.FindWithTag("Collecter");
        Counter = GameObject.Find("CollectedCounter").GetComponent<CollectedCounter>();

        _rb = GetComponent<Rigidbody>();

        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pizza"))
        {
            isOnPizza = true;

            //Freeze all positions
            _rb.constraints = RigidbodyConstraints.FreezePosition;

            //does not collide with player once it is on pizza
            GetComponent<Collider>().enabled = false;
        }

        if (collision.gameObject.CompareTag("Collecter") && !isOnPizza)
        {

            _audioSource.PlayOneShot(trashSFX, 1f);
        
            // print to console
            print("Rat collected Trash");

            Destroy(gameObject, 0.2f);

            // update Counter
            Counter.UpdateTrash(TrashCount);
        }
    }
}
