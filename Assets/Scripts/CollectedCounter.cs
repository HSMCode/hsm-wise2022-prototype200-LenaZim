using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedCounter : MonoBehaviour
{
    public int IngredientCount;
    public int CurrentIngredients;

    public int TrashCount;
    public int CurrentTrash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateIngredients(int IngredientCount)
    {
        CurrentIngredients += IngredientCount;
    }

    public void UpdateTrash(int TrashCount)
    {
        CurrentTrash += TrashCount;
    }
}
