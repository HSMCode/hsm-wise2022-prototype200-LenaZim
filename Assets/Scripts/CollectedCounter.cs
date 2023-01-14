using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedCounter : MonoBehaviour
{
    // for ingredients
    public int IngredientCount;
    public int CurrentIngredients;

    private Text ingredientsUI;
    private string ingredientsText = "Ingredients collected:  ";

    // for trash
    public int TrashCount;
    public int CurrentTrash;

    private Text trashUI;
    private string trashText = "Trash collected:  ";


    // Start is called before the first frame update
    void Start()
    {
        ingredientsUI = GameObject.Find("IngredientsText").GetComponent<Text>();
        trashUI = GameObject.Find("TrashText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateIngredients(int IngredientCount)
    {
        CurrentIngredients += IngredientCount;
        ingredientsUI.text = ingredientsText + CurrentIngredients.ToString();
    }

    public void UpdateTrash(int TrashCount)
    {
        CurrentTrash += TrashCount;
        trashUI.text = trashText + CurrentTrash.ToString();
    }
}
