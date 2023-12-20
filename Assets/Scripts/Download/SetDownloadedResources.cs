using UnityEngine;
using UnityEngine.UI;

namespace Download
{
    public class SetDownloadedResources:MonoBehaviour
    {
        [SerializeField] private GameObject _object3D;
        [SerializeField] private RawImage _imageA;
        [SerializeField] private Image _imageB;

        public RawImage ImageA
        {
            get => _imageA;
            set => _imageA = value;
        }

        public Image ImageB
        {
            get => _imageB;
            set => _imageB = value;
        }

        public GameObject Object3D
        {
            get => _object3D;
            set => _object3D = value;
        }
    }
}