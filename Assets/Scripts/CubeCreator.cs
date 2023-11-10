using UnityEngine;

public class CubeCreator : MonoBehaviour
{
    [SerializeField] private GameObject dummyObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(dummyObject).SetActive(true);
        }
    }
}
