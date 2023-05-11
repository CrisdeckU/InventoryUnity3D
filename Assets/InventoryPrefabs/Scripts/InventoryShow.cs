using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryShow : MonoBehaviour
{
    public bool isOpen;
    public GameObject inventoryCanvas;
    public InventoryManager inventoryList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if(isOpen)
            {
                CloseInventory();
            }else{
                OpenInventory();
            }
        }
        
    }

    public void OpenInventory()
    {
        inventoryCanvas.SetActive(true);
        Time.timeScale = 0f;
        isOpen =true;
        inventoryList.ListItems();
    }

        public void CloseInventory()
    {
        inventoryCanvas.SetActive(false);
        Time.timeScale = 1f;
        isOpen =false;
    }
}
