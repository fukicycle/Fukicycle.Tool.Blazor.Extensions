using Fukicycle.Tool.Blazor.Extensions.Enums;
using Fukicycle.Tool.Blazor.Extensions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fukicycle.Tool.Blazor.Extensions.Containers
{
    public sealed class DialogContainer
    {
        private readonly IDialogService _dialogService;
        public DialogContainer(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public event Action OnChanged = null!;

        public string Message { get; private set; } = string.Empty;
        public string Title { get; private set; } = string.Empty;
        public DialogType DialogType { get; private set; } = DialogType.Info;
        public DialogButton DialogButton { get; private set; } = DialogButton.OK;
        public bool IsShow { get; private set; }

        public void SetDialogContent(string title, string message, DialogType dialogType, DialogButton dialogButton)
        {
            Title = title;
            Message = message;
            DialogType = dialogType;
            DialogButton = dialogButton;
            IsShow = true;
            OnChanged.Invoke();
        }
    }
}
