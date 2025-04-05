using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

 
    public class Skills : MonoBehaviour
    {
        public bool Iscd { get; set; } = true;
         public readonly int Cooltime=4 ;
        public float cd { get; set; }

        public void UseSkill()
        {
            if (Iscd)
            {
                Iscd = false;
                StartCoroutine(CoolDown());
            }
        }

        IEnumerator CoolDown()
        {
            yield return new WaitForSeconds(Cooltime);
            Iscd = true;
        }
        
    }


