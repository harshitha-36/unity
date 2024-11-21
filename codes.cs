//collide then scene change

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameObject collisionGameObject = other.gameObject;

        if (collisionGameObject.CompareTag("Player")) // Check if tag is "Player"
        {
            SceneManager.LoadScene(1); // Load scene with index 1
        }
    }
}


// increase score on collision

using UnityEngine;
using TMPro;

public class ScoreOnCollision : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        // Update the score when a collision occurs
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}

// scene change on button click



using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChangeOnButtonClick : MonoBehaviour
{
    public TextMeshProUGUI buttonText; // Assign the button TextMeshProUGUI component in the Inspector

    void Start()
    {
        // Add a listener to the button to detect clicks
        buttonText.gameObject.AddComponent<TMPro.TMP_TextEventHandler>().textAutoSizing = true;
        buttonText.gameObject.GetComponent<TMPro.TMP_TextEventHandler>().onPointerClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Load the desired scene when the button is clicked
        SceneManager.LoadScene("YourSceneName");
    }
}



// point light 


using UnityEngine;
using UnityEngine.UI;

public class TogglePointLight : MonoBehaviour
{
    public Light pointLight;
    public Button toggleButton;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleLight);
    }

    void ToggleLight()
    {
        pointLight.enabled = !pointLight.enabled;
    }
}


