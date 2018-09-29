using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimationController : MonoBehaviour {


    Animator _animator;
	void Start () {

        _animator = GetComponent<Animator>();
        AssignRandomAnimation();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F)) AssignRandomAnimation();
	}

    private void AssignRandomAnimation()
    {
        _animator.SetTrigger("stopAnim");
        int animId = Random.Range(0, 10);
        _animator.SetInteger("AnimID", animId);

    }
}
