using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatterhornSetSelector : MonoBehaviour
{
    public Sprite[] mhPreview;
    public GameObject[] mhDevider, mhLayout, mhScreen;
    int currLayout = -1, targetLayout = 0;

    void Start()
    {
        mhEmptyBtn();
    }

    void Update()
    {
        //just for test
        if (Input.GetKeyUp(KeyCode.Keypad0))
        {
            mhEmptyBtn();
        }
        else if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            mh1Btn();
        }
        else if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            mh2Btn();
            
        }
        else if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            mh3Btn();
            
        }
        else if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            mh12Btn();
        }
        else if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            mh23Btn();
        }
        else if (Input.GetKeyUp(KeyCode.Keypad6))
        {
            mh123Btn();
        }
    }


    public void mhEmptyBtn()
    {
        targetLayout = 0;
        if (currLayout != targetLayout)
        {
            for (int i = 0; i < mhLayout.Length; i++)
            {
                mhLayout[i].SetActive(false);
            }
            for (int j = 0; j < mhDevider.Length; j++)
            {
                mhDevider[j].SetActive(false);
            }
            currLayout = 0;
        }
        else
        {
            Debug.Log("You're here");
        }
        
    }
    public void mh1Btn()
    {
        Debug.Log("TP to MH1");
        targetLayout = 1;
        if(currLayout != targetLayout)
        {
            mh1n2n3();
            currLayout = 1;
        }
        else
        {
            Debug.Log(" You're here");
        }
    }
    public void mh2Btn()
    {
        Debug.Log("TP to MH2");
        targetLayout = 2;
        if (currLayout != targetLayout)
        {
            mh1n2n3();
            currLayout = 2;
        }
        else
        {
            Debug.Log(" You're here");
        }
    }
    public void mh3Btn()
    {
        Debug.Log("TP to MH3");
        targetLayout = 3;
        if (currLayout != targetLayout)
        {
            mh1n2n3();
            currLayout = 3;
        }
        else
        {
            Debug.Log(" You're here");
        }
    }
    public void mh12Btn()
    {
        targetLayout = 4;
        if (currLayout != targetLayout)
        {
            Debug.Log("Remove devider 12");
            mhDevider12();
            currLayout = 4;
        }
        else
        {
            Debug.Log(" You're here");
        }

    }
    public void mh23Btn()
    {
        targetLayout = 5;
        if (currLayout != targetLayout)
        {
            Debug.Log("remove devider 23");
            mhDevider23();
            currLayout = 5;
        }
        else
        {
            Debug.Log(" You're here");
        }
    }

    public void mh123Btn()
    {
        Debug.Log("Set 123");
        targetLayout = 123;
        if (targetLayout != currLayout)
        {
            for (int i = 0; i < mhLayout.Length; i++)
            {
                if (i == 5)
                {
                    if (!mhLayout[i].activeInHierarchy)
                    {
                        mhLayout[i].SetActive(true);
                    }
                }
                else
                {
                    if (mhLayout[i].activeInHierarchy)
                    {
                        mhLayout[i].SetActive(false);
                    }
                }
            }
            for (int j = 0; j < mhDevider.Length; j++)
            {
                if (mhDevider[j].activeInHierarchy)
                {
                    mhDevider[j].SetActive(false);
                }
            }

            currLayout = 123;
        }
        else
        {
            Debug.Log(" You're here");
        }

    }

    public void mh1n2n3()   
    {
        for (int i = 0; i < mhLayout.Length; i++)
        {
            if (i <= 2 && !mhLayout[i].activeInHierarchy)
            {
                mhLayout[i].SetActive(true);
            }
            else if(i >= 3 && mhLayout[i].activeInHierarchy)
            {
                mhLayout[i].SetActive(false);
            }
        }
        for (int j = 0; j < mhDevider.Length; j++)
        {
            if (!mhDevider[j].activeInHierarchy)
            {
                mhDevider[j].SetActive(true);
            }
        }
    }

    public void mhDevider12()
    {
        targetLayout = 12;
        if(targetLayout != currLayout)
        {
            for (int i = 0; i < mhDevider.Length; i++)
            {
                if (i == 1)         //shall be active
                {
                    if (!mhDevider[i].activeInHierarchy)
                    {
                        mhDevider[i].SetActive(true);
                    }
                }
                else                //shall not be active
                {
                    if (mhDevider[i].activeInHierarchy)
                    {
                        mhDevider[i].SetActive(false);
                    }
                }
            }

            for (int j = 0; j < mhLayout.Length; j++)
            {
                if (j == 2 || j == 3)
                {
                    if (!mhLayout[j].activeInHierarchy)
                    {
                        mhLayout[j].SetActive(true);
                    }
                }
                else
                {
                    if (mhLayout[j].activeInHierarchy)
                    {
                        mhLayout[j].SetActive(false);
                    }
                }
            }

            currLayout = 12;
        }
        else
        {
            Debug.Log(" You're here");
        }
    }

    public void mhDevider23()
    {
        targetLayout = 23;
        if(targetLayout != currLayout)
        {
            for (int i = 0; i < mhDevider.Length; i++)
            {
                if (i == 0)         //shall be active
                {
                    if (!mhDevider[i].activeInHierarchy)
                    {
                        mhDevider[i].SetActive(true);
                    }
                }
                else                //shall not be active
                {
                    if (mhDevider[i].activeInHierarchy)
                    {
                        mhDevider[i].SetActive(false);
                    }
                }
            }

            for (int j = 0; j < mhLayout.Length; j++)
            {
                if (j == 0 || j == 4)
                {
                    if (!mhLayout[j].activeInHierarchy)
                    {
                        mhLayout[j].SetActive(true);
                    }
                }
                else
                {
                    if (mhLayout[j].activeInHierarchy)
                    {
                        mhLayout[j].SetActive(false);
                    }
                }
            }

            currLayout = 23;
        }
        else
        {
            Debug.Log(" You're here");
        }
    }

    

    /*public void mhLayoutSelector()
    {
        if(targetLayout != currLayout)
        {
            switch (targetLayout)
            {
                case 0:
                    for(int i = 0; i < mhLayout.Length; i++)
                    {
                        mhLayout[i].SetActive(false);
                    }
                    for(int j = 0; j < mhDevider.Length; j++)
                    {
                        mhDevider[j].SetActive(false);
                    }
                    currLayout = 0;
                    break;
                case 1:
                    //tp to mh1
                    Debug.Log("TP to MH1");
                    mh1n2n3();
                    currLayout = 1;
                    break;
                case 2:
                    //tp to mh2
                    Debug.Log("TP to MH2");
                    mh1n2n3();
                    currLayout = 2;
                    break;
                case 3:
                    //tp to mh3;
                    Debug.Log("TP to MH3");
                    mh1n2n3();
                    currLayout = 3;
                    break;
                case 4:
                    Debug.Log("mode 12 & 3");
                    mhDevider12();
                    currLayout = 4;
                    break;
                case 5:
                    Debug.Log("mode 1 & 23");
                    mhDevider23();
                    currLayout = 5;
                    break;
            }
        }
        else
        {
            Debug.Log("you are here");
        }
        
    }*/
}