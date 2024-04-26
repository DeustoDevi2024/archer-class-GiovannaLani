using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {

        // Cuántas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;

        private Animator animator;

        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;

        public Light directional;

        private AudioSource audioSource;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            audioSource = GetComponent<AudioSource>();
        }
        private void Update()
        {
            if(hitPoints<=0)
            {
                StartCoroutine(Die());
            }
        }
        // Método que se llamará cuando el enemigo reciba un impacto
        public void Hit()
        {
            audioSource.Play();
            animator.SetTrigger("Hit");
            hitPoints--;
        }

        private IEnumerator Die()
        {
            animator.SetTrigger("Die");
            directional.enabled = true;
            yield return new WaitForSeconds(3f);
            directional.enabled = false;
            Destroy(gameObject);
        }

    }

}