using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

[RequireComponent(typeof(PostProcessingBehaviour))]
public class QualityManager : MonoBehaviour
{
    [SerializeField] private PostProcessingProfile _low, _medium, _high;

    private PostProcessingBehaviour _postProcessingBehaviour;

	void Start ()
    {
        _postProcessingBehaviour = GetComponent<PostProcessingBehaviour>();
	}
	
    public void ToggleQuality(int choice)
    {
        PostProcessingProfile targetProfile = null;

        switch(choice)
        {
            case 0:
                targetProfile = _low;
                break;
            case 1:
                targetProfile = _medium;
                break;

            case 2:
                targetProfile = _high;
                break;
        }
        _postProcessingBehaviour.profile = targetProfile;
    }
}
