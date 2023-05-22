using UnityEngine;

public class EnterExitCapsule : MonoBehaviour
{
    // Object ini sendiri
    [SerializeField]
    private CapsuleCollider regionObject;

    // Saiz region bila Start dan Exit
    [SerializeField]
    private float smallRegion = 5f;

    // Saiz region bila Enter
    [SerializeField]
    private float bigRegion = 55f;

    // Dua GameObject untuk toggle
    public GameObject ShowOnStart;
    public GameObject HideOnStart;

    // Start is called before the first frame update
    void Start()
    {
        regionObject = GetComponent<CapsuleCollider>();
        ShowOnStart.SetActive(true);
        HideOnStart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            regionObject.radius = bigRegion;
            ShowOnStart.SetActive(false);
            HideOnStart.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            regionObject.radius = smallRegion;
            ShowOnStart.SetActive(true);
            HideOnStart.SetActive(false);
        }
    }
}
// Shamsul Amar
// 10-04-2022 Sun
// Script ini tambahkan pada Capsule
// Untuk kawalan toggle dua object bila Player masuk ke region Collider
// Radius collider berubah besar ketika enter dan mengecil ketika mula dan ketika exit
// Supaya sedikit terundur atau terkedepan tidak mudah keluar dari region