using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsInteraction : MonoBehaviour
{
    public GameObject step1,step2,step3,step4,step5,step6,step7,step8,step9,step10,finalstep;
    //public Color mycolor;
    public GameObject startinstruction;
    //public string welcomestring = "Welcome to VR PC Building!";
    public GameObject instruction1;
    public GameObject instruction2;
    public GameObject instruction3;
    public GameObject instruction4;
    public GameObject instruction5;
    public GameObject instruction6;
    public GameObject instruction7;
    public GameObject instruction8;
    public GameObject instruction9;
    public GameObject instruction10;
    public GameObject finalinstruction;


    // Start is called before the first frame update
    void Start()
    {
        startinstruction.SetActive(true);
        instruction1.SetActive(false);
        instruction2.SetActive(false);
        instruction3.SetActive(false);
        instruction4.SetActive(false);
        instruction5.SetActive(false);
        instruction6.SetActive(false);
        instruction7.SetActive(false);
        instruction8.SetActive(false);
        instruction9.SetActive(false);
        instruction10.SetActive(false);
        finalinstruction.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void step_one()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(true);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }

    public void step_two()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(true);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }
    public void step_three()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(true);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }
    public void step_four()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(true);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }
    public void step_five()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(true);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }
    public void step_six()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(true);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }
    public void step_seven()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(true);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }
    public void step_eight()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(true);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }
    public void step_nine()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(true);
            instruction10.SetActive(false);
            finalinstruction.SetActive(false);
        }

    }
    public void step_ten()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(true);
            finalinstruction.SetActive(false);
        }

    }
    public void finish_step()
    {
        //GameObject.Find("Instruction 1").GetComponentInChildren<Text>().text = "STEP 1 : PUT THE PC CASE ON THE TABLE";

        if (step1 == true)
        {
            startinstruction.SetActive(false);
            instruction1.SetActive(false);
            instruction2.SetActive(false);
            instruction3.SetActive(false);
            instruction4.SetActive(false);
            instruction5.SetActive(false);
            instruction6.SetActive(false);
            instruction7.SetActive(false);
            instruction8.SetActive(false);
            instruction9.SetActive(false);
            instruction10.SetActive(false);
            finalinstruction.SetActive(true);
        }

    }
}
