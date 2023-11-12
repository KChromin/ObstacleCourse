using UnityEngine;

public class DelayedDropper : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private MeshRenderer objectRenderer;

    [SerializeField]
    private int timeToDrop = 3;

    private bool droped = false;

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
        objectRenderer = GetComponent<MeshRenderer>();

        objectRigidbody.useGravity = false;
        objectRenderer.enabled = false;
    }

    private void Update()
    {
        WaitTillDrop();
    }

    private void WaitTillDrop()
    {
        if (droped) return;
        if (!(Time.time >= timeToDrop)) return;
        
        objectRigidbody.useGravity = true;
        objectRenderer.enabled = true;
    }
}