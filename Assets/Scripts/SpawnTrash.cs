using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour

{
public  GameObject Trash;
public GameObject [] Trashs;

    // Var for spawn ammount of method
    public int spawnAmount = 1;
    

    // Variables for radomizing position
   
   
   
    // public float spawnPositionXa = 4;
    // public float spawnPositionXb = 4;
    // public float spawnPositionZa = 4;
    // public float spawnPositionZb = 4;

    public float spawnHeight; 

    /// Variables Invoke Repeating
    public float startDelay= 5f;
    public float spawnInterwal = 50f;

    // Start is called before the first frame update
    void Start()
    {
        SpawningTrashParam(spawnAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawningTrashParam(int amount)
    {
        for (int i = 0; i < amount; i++)
         {
             // generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3(0,spawnHeight,0);
            
            //spawnHeight,RandomRange(-spawnPositionZa,spawnPositionZa);
            
            //new Vector3(Random.Range(-spawnPositionXa, spawnPositionXb),spawnHeight ,Random.Range(-spawnPositionZa,spawnPositionZb));

            // instantiate decoy
            Instantiate(Trash, spawnPosition, Trash.transform.rotation);
         }
    }
}

// void SpawningEnemy()
    // {
    //         for (int i = 0; i < 5; i++)
    //         {
    //             int enemysIndex = Random.Range(0,Enemys.Length);

    //             // generate random spawn position between the defined values
    //             Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionXa, spawnPositionXb),0 ,Random.Range(-spawnPositionZa,spawnPositionZb));

    //             // instantiate decoy
    //             Instantiate(Enemys[enemysIndex],spawnPosition,Enemys[enemysIndex].transfom.rotation);
    //         }
    // }

    