using UnityEngine;
using UnityEngine.UI;

namespace Haptic
{
    public class Sample : MonoBehaviour
    {
        [SerializeField] private Button _selection;

        [SerializeField] private Button _impactLight;

        [SerializeField] private Button _impactMedium;

        [SerializeField] private Button _impactHeavy;

        [SerializeField] private Button _nortificationSuccess;

        [SerializeField] private Button _nortificationWarning;

        [SerializeField] private Button _nortificationError;

        private void Start()
        {
            _selection.GetComponentInChildren<Text>().text = "Selection";
            _selection.onClick.AddListener(() => HapticPlugin.Generate(FeedBackType.Selection));

            _impactLight.GetComponentInChildren<Text>().text = "ImpactLight";
            _impactLight.onClick.AddListener(() => HapticPlugin.Generate(FeedBackType.ImpactLight));

            _impactMedium.GetComponentInChildren<Text>().text = "ImpactMedium";
            _impactMedium.onClick.AddListener(() => HapticPlugin.Generate(FeedBackType.ImpactMedium));

            _impactHeavy.GetComponentInChildren<Text>().text = "ImpactHeavy";
            _impactHeavy.onClick.AddListener(() => HapticPlugin.Generate(FeedBackType.ImpactHeavy));

            _nortificationSuccess.GetComponentInChildren<Text>().text = "NortificationSuccess";
            _nortificationSuccess.onClick.AddListener(() => HapticPlugin.Generate(FeedBackType.NortificationSuccess));

            _nortificationWarning.GetComponentInChildren<Text>().text = "NortificationWarning";
            _nortificationWarning.onClick.AddListener(() => HapticPlugin.Generate(FeedBackType.NortificationWarning));

            _nortificationError.GetComponentInChildren<Text>().text = "NortificationError";
            _nortificationError.onClick.AddListener(() => HapticPlugin.Generate(FeedBackType.NortificationError));
        }
    }
}