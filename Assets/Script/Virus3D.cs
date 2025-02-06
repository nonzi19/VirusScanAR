using UnityEngine;
using UnityEngine.SceneManagement;

public class Virus3D : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

    void Update()
    {
        // Get input from the user
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the rotation based on user input
        Vector3 rotation = new Vector3(verticalInput, horizontalInput, 0) * rotationSpeed * Time.deltaTime;

        // Apply the rotation to the object
        transform.Rotate(rotation);
    }


    public void Back()
    {
         SceneManager.LoadScene("ARScan");
 
    }
}