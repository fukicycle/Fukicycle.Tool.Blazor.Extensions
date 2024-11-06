using Fukicycle.Tool.Blazor.Extensions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fukicycle.Tool.Blazor.Extensions.Services
{
    public interface IDialogService
    {
        Task ShowAsync(string title, string message, DialogType dialogType, DialogButton dialogButton);
        Task ShowAsync(string message, DialogType dialogType, DialogButton dialogButton);
        Task ShowAsync(string message, DialogType dialogType);
        Task ShowAsync(string message, DialogButton dialogButton);
        Task ShowAsync(string message);
    }
}
