using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Buatkan satu GameObject jenis Cube
// Nyah tandakan Mesh Renderer
// Tandakan Is Trigger di bahagian Collider
// Kemudian Add Component script ini padanya

// Buatkan dua empty GameObject dan namakan akan dia masing-masing sebagai A dan B
// Position A lebih tinggi dari position B

// Nota: Player ialah child kepada MainCamera dan mesti di-tag sebagai Player
// Script ini untuk buatkan ARModel bergerak dari A (Atas) ke B (Bawah)
// bila Player memasuki ruang Collider (Cube)
// Ini memberi peluang pengguna melihat ARModel yang mungkin besar atas tinggi
// dari pandangan atas
// Dibila pengguna bergerak keluar dari ruang Collider, ARModel kembali ke
// position A, ke tempat yang lama


public class LiftController : MonoBehaviour
{
    public GameObject ObjectA, ObjectB, ARModel;
    bool InsideCollider = false;
    // Initial Player di luar ARModel

    [SerializeField]
    float LajuGerakan = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Initial ARModel to ObjectA position
        ARModel.transform.position = ObjectA.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (InsideCollider == true)
        {
            ARModel.transform.position = Vector3.MoveTowards(ARModel.transform.position, ObjectB.transform.position, LajuGerakan * Time.deltaTime);
            //ARModel move from A to B

        }

        if (InsideCollider == false)
        {
            ARModel.transform.position = Vector3.MoveTowards(ARModel.transform.position, ObjectA.transform.position, LajuGerakan * Time.deltaTime);
            //ARModel move from B to A

        }
    }

    // Trigger part
    // Bila Player masuk ke dalam Collider, laksanakan baris berikut

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("MainCamera enter Collider");
            InsideCollider = true;

        }
    }

    // Bila Player keluar dari Collider, laksanakan baris berikut
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("MainCamera exit Collider");
            InsideCollider = false;

        }
    }
}

// Lift Controller
// Created by Shamsul Amar bin Hashim
// Created 11 Oct 2020
// Last Updated 22 Apr 2021