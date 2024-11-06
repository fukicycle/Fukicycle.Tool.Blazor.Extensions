using Fukicycle.Tool.Blazor.Extensions.Containers;
using Fukicycle.Tool.Blazor.Extensions.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fukicycle.Tool.Blazor.Extensions.Services
{
    public sealed class DialogService : IDialogService
    {
        private readonly DialogContainer _dialogContainer;
        public DialogService(DialogContainer dialogContainer)
        {
            _dialogContainer = dialogContainer;
        }
        private TaskCompletionSource<DialogResult>? _tcs;
        public Task ShowAsync(string title, string message, DialogType dialogType, DialogButton dialogButton)
        {
            _tcs = new TaskCompletionSource<DialogResult>();
            _dialogContainer.SetDialogContent(title, message, dialogType, dialogButton);
            return _tcs.Task;
        }

        public Task ShowAsync(string message, DialogType dialogType, DialogButton dialogButton)
        {
            return ShowAsync(dialogType.ToString(), message, dialogType, dialogButton);
        }

        public Task ShowAsync(string message, DialogType dialogType)
        {
            return ShowAsync(dialogType.ToString(), message, dialogType, DialogButton.OK);
        }

        public Task ShowAsync(string message, DialogButton dialogButton)
        {
            return ShowAsync(nameof(DialogType.Info), message, DialogType.Info, dialogButton);
        }

        public Task ShowAsync(string message)
        {
            return ShowAsync(nameof(DialogType.Info), message, DialogType.Info, DialogButton.OK);
        }
    }
}
