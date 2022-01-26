using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using Assets;

public class Boule : MonoBehaviour
{



    public float hauteurForce;
    public float longueurForce;
    public float hauteurLance;
    public float directionLance;

    public bool EnMouvement;
    public DateTime timeCollision;
    public float forceRotation = 50f;
    public bool estJoue;
    public Boule Ghost;
    public DateTime dateLunchGhost;

    public bool EstCollision { get; set; }
    void Start()
    {
        this.dateLunchGhost = DateTime.Now;

        this.timeCollision = DateTime.Now;
        this.estJoue = false;
    }

    // Update is called once per frame
    void Update()
    {
        LimiterRotation();
        DateTime now = DateTime.Now;
        this.UpdateValeur();
        if (!this.estJoue && this.name != "Ghost")
            this.GenererGhost();


    }

    private void GenererGhost()
    {
        //  DestroyGhost();
        if (!estJoue)
            InstanciateGhost();
    }

    private void InstanciateGhost()
    {
        DateTime nowTime = DateTime.Now;
        if (nowTime.TimeOfDay.TotalMilliseconds - this.dateLunchGhost.TimeOfDay.TotalMilliseconds > 1600 )
        {
            this.DestroyGhost();
            GameObject ghostObj = Instantiate(Resources.Load("Boule")) as GameObject;
            ghostObj.name = "Ghost";
            this.Ghost = (Boule)ghostObj.GetComponent(typeof(Boule));
            this.Ghost.GetComponent<Rigidbody>().GetComponent<Collider>().enabled = false;
            //  this.Ghost.Update();
            this.Ghost.ForceUpdate();
            this.Ghost.LancerAleatoire(0.5f);
            this.dateLunchGhost = DateTime.Now;


        }
    }

    private void ForceUpdate()
    {
        LimiterRotation();
        DateTime now = DateTime.Now;
        this.UpdateValeur();

    }

    private void DestroyGhost()
    {
        GameObject ghostObjActuel = GameObject.Find("Ghost");
        if (ghostObjActuel != null)
        {
            Destroy(ghostObjActuel);
        }
    }

    private void LimiterRotation()
    {
        if (this.GetComponent<Rigidbody>().velocity.magnitude < 0.25f)
        {
            this.GetComponent<Rigidbody>().freezeRotation = true;
        }
    }

    private void UpdateValeur()
    {
        EtablirEstEnMouvement();
        EtablirValeurUI();
        PositionnerHauteurBoule();

    }

    private void EtablirValeurUI()
    {
        GameObject userInput = GameObject.Find("UserInput");
        UserInput input = (UserInput)userInput.GetComponent(typeof(UserInput));



        this.directionLance = this.GetValueForce(input.DirectionLance.value, -2, 2);
        this.hauteurForce = this.GetValueForce(input.HauteurForce.value, -5, 6);
        this.longueurForce = this.GetValueForce(input.LongueurForce.value, 1, 23);
        this.hauteurLance = this.GetValueForce(input.HauteurLance.value, 1, 2.8f);

    }

    private void EtablirValeurUI(float precision)
    {
        GameObject userInput = GameObject.Find("UserInput");
        UserInput input = (UserInput)userInput.GetComponent(typeof(UserInput));



        this.directionLance = this.GetValueForce(input.DirectionLance.value, -2, 2,precision);
        this.hauteurForce = this.GetValueForce(input.HauteurForce.value, -5, 6,precision);
        this.longueurForce = this.GetValueForce(input.LongueurForce.value, 1, 23,precision);
        this.hauteurLance = this.GetValueForce(input.HauteurLance.value, 1, 2.8f,precision);
    }



    private void EtablirEstEnMouvement()
    {
        if (this.GetComponent<Rigidbody>().velocity.magnitude > 0.0f)
            this.EnMouvement = true;

    }

    private void PositionnerHauteurBoule()
    {
        if (!EnMouvement)
            this.GetComponent<Rigidbody>().transform.position = new Vector3(this.GetComponent<Rigidbody>().transform.position.x, this.hauteurLance, this.GetComponent<Rigidbody>().transform.position.z);
    }

    public void LancerAleatoire(float precision)
    {
        this.estJoue = true;
        this.EtablirValeurUI(precision);
        this.AppliquerForce();

        //  Vector3 forcePosition = new Vector3(this.rigidbody.position.x,this.effetAvant,this.effetCote);
        this.AppliquerForceRotation();
        this.GetComponent<Rigidbody>().useGravity = true;

    }



    private void AppliquerForceRotation()
    {
        /*
        Vector3 vector = Vector3.right;
        this.rigidbody.AddTorque(Vector3.right * this.effetCote*this.forceRotation*this.rigidbody.mass);
      
            this.rigidbody.AddTorque(Vector3.back * this.effetAvant * this.forceRotation*this.rigidbody.mass);
        */
    }

    private void AppliquerForce()
    {
        Vector3 dirLancer = new Vector3(-this.longueurForce, this.hauteurForce, this.directionLance);
        this.GetComponent<Rigidbody>().AddForce(dirLancer, ForceMode.Impulse);
    }

    public void Reset()
    {
        if (!estJoue)
        {
            this.GetComponent<Rigidbody>().position = new Vector3(5.15f, 2.8F, 0);
            this.transform.position = new Vector3(5.15f, 2.8F, 0);
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().useGravity = false;
            this.EnMouvement = false;
            this.EstCollision = false;
        }
    }

    void OnCollisionEnter()
    {
        if (!this.EstCollision)
        {
            this.EstCollision = true;
            this.timeCollision = DateTime.Now;
        }
    }

    private float GetValueForce(float value, float min, float max)
    {
        float res = 0;

        res = ((System.Math.Abs(min) + System.Math.Abs(max)) * value) + min;

        return res;
    }
    private float GetValueForce(float value, float min, float max, float precision)
    {
        float res = 0;
       
        System.Random rand = new System.Random();
        float precisionAppliqué = Outils.AppliquerPourcentagePrecision(precision);

        res = (((System.Math.Abs(min * precisionAppliqué) + System.Math.Abs(max * precisionAppliqué)) * value) + min);
     
           
    
        
    

        return res;
    }

}
