using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    public GameObject targetObject; // The object to scale
    public float targetScaleY = 1.0f; // The desired Y scale

    // Method to set the Y scale to the target value
    public void SetScaleYToOne()
    {
        if (targetObject != null)
        {
            Debug.Log("Before: " + targetObject.transform.localScale);

            Vector3 currentScale = targetObject.transform.localScale;
            currentScale.y = targetScaleY; // Set the Y scale to 1
            targetObject.transform.localScale = currentScale;
            Debug.Log("After: " + targetObject.transform.localScale);

        }
    }
}
