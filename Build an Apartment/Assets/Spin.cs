using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{

    public bool rotateObject = true;
    private Button mouseButton;

    // Use this for initialization
    void Start()
    {
        mouseButton = GetComponent<Button>();
        mouseButton.onClick.AddListener(invertBoolean);
    }

    void invertBoolean()
    {
        rotateObject = !rotateObject;
    }

    // Update is called once per frame
    void Update()
    { 

        if (rotateObject == true)
        {
            transform.Rotate(new Vector3(Time.deltaTime * 0, 4, 0));
        }


    }
}