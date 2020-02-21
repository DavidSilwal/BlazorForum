﻿using Microsoft.AspNetCore.Components;
using System;

namespace BlazorForum.Pages.Components.BlazorModal
{
    public interface IBlazorModal
    {
        event Action<string, RenderFragment> OnShow;
        event Action OnClose;
        void Show<T>(string title, params BlazorModalParameter[] parameters) where T : ComponentBase;
        void Close();
    }
}
