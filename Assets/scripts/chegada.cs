using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chegada : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
