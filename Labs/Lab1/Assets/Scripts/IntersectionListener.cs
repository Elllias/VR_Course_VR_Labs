using UnityEngine;

public class IntersectionListener : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning($"{gameObject.name} соприкоснулся с {other.gameObject.name}");
        other.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
