using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using ModdingUtils.MonoBehaviours;

namespace BPP.MonoBehaviors
{
    public class Alcoholic : ReversibleEffect
    {
        GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
        bool crRunning = false;
        float inversionTime = 6f;
        public override void OnAwake()
        {
            gameManager = GameObject.FindObjectOfType<GameManager>();
        }

        public override void OnStart()
        {
        }

        public override void OnUpdate()
        {
            if (crRunning == false)
            {
                StartCoroutine(invertControls());
                crRunning = true;
            }
            
        }

        IEnumerator invertControls()
        {
            while (true)
            {
                if (true)
                {
                    int secTilInvert = UnityEngine.Random.Range(5, 10);
                    yield return new WaitForSeconds((float)secTilInvert);
                    //checking again after timer
                    //game manager can't be found? test later
                    if (true)
                    {
                        base.characterStatModifiersModifier.movementSpeed_mult = -1f;
                        yield return new WaitForSeconds(inversionTime);
                        base.characterStatModifiersModifier.movementSpeed_mult = 1f;
                    }
                
                }
                else
                {
                    Debug.Log("Round not in progress, postponing inversion timer");
                }
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
