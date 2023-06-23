using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class test : MonoBehaviour
    {
        public GameObject AAA;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            //float aaa = Vector3.Dot(this.gameObject.transform.position, AAA.transform.position.normalized);
            //Vector3 vec3 = this.gameObject.transform.position - AAA.transform.position;
            //float aaa = Vector3.Dot(vec3.normalized,transform.right);
            //float aaa = Vector3.Dot(vec3, this.gameObject.transform.position.normalized);

            Debug.Log("aaa = " + check222());
        }


        bool check() {

            Vector3 vec3 = this.gameObject.transform.position - AAA.transform.position;
            float forwardDoatA = Vector3.Dot(this.gameObject.transform.forward,vec3);
            if (forwardDoatA > 0 && forwardDoatA <= 5) {
                if (Mathf.Abs(Vector3.Dot(this.gameObject.transform.right, vec3)) < 5) {
                    return true;
                }
            }
            return false;
        }

        bool check222()
        {
            Vector3 v3 = Vector3.Normalize(this.gameObject.transform.position);
            Debug.Log("this.gameObject.transform.right = " + this.gameObject.transform.right + "this.gameObject.transform.forward = " + this.gameObject.transform.forward + " v3 = " + v3 + "normalized = "  + this.gameObject.transform.position.normalized);
            Vector3 vec3 = AAA.transform.position - this.gameObject.transform.position;
            float forwardDoatA = Vector3.Dot(vec3, this.gameObject.transform.forward.normalized);
            if (forwardDoatA > 0 && forwardDoatA <= 5)
            {
                if (Mathf.Abs(Vector3.Dot(this.gameObject.transform.right, vec3)) < 5)
                {
                    return true;
                }


            }
            return false;
        }

        bool check333()
        {

            Vector3 vec3 = AAA.transform.position - this.gameObject.transform.position;

            float forwardDoatA = Vector3.Dot(vec3, this.gameObject.transform.forward.normalized);
            if (forwardDoatA <= 0 && forwardDoatA > 5)
            {
                return false;
            }

            Vector3 newVec = Quaternion.Euler(0f, 90f, 0f) * this.gameObject.transform.forward;
            float rightDistance = Vector3.Dot(vec3, newVec.normalized);
            return Mathf.Abs(rightDistance) <= 5;

        /*
            if (Mathf.Abs(Vector3.Dot(this.gameObject.transform.right, vec3)) < 5)
            {
                return true;
            }
            return false;
        */
        }
    }
}
