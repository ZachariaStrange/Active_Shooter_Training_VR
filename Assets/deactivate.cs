using UnityEngine;



public class DeactivateGameObject : MonoBehaviour

{

    public GameObject objectToDeactivate; // Public variable to reference the game object you want to disable



    public void DeactivateObject() 

    {

        objectToDeactivate.SetActive(false); // Set the game object to inactive when the button is pressed

    }

}