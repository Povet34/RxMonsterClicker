using UnityEngine;
using UnityEngine.UI;
using VContainer;
using R3;

public class MonsterView : MonoBehaviour
{
    [SerializeField] private Button clickButton;
    [SerializeField] private Text clickCountText;

    private MonsterViewModel _viewModel;

    [Inject]
    public void Construct(MonsterViewModel viewModel)
    {
        _viewModel = viewModel;
    }

    private void Start()
    {
        clickButton.onClick.AddListener(_viewModel.Click);

        _viewModel.TotalClicks
            .Subscribe(value => clickCountText.text = $"Clicks: {value}")
            .AddTo(_disposables); // R3의 AddTo는 없으므로 직접 IDisposable 리스트 관리
    }

    private readonly CompositeDisposable _disposables = new();

    private void OnDestroy()
    {
        _disposables.Dispose();
    }
}
