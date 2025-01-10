﻿using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;

namespace Donate.Data.Models;

public class FormValidation : ComponentBase
{
    private ValidationMessageStore? messageStore;

    [CascadingParameter]
    public EditContext? CurrentEditContext { get; set; }

    protected override void OnInitialized()
    {
        if (CurrentEditContext == null)
        {
            throw new InvalidOperationException(
                $"{nameof(FormValidation)} requires a cascading " +
                $"parameter of type {nameof(EditContext)}. " +
                $"For example, you can use {nameof(FormValidation)} " +
                $"inside an {nameof(EditForm)}.");
        }

        messageStore = new(CurrentEditContext);

        CurrentEditContext.OnValidationRequested += (s, e) =>
            messageStore.Clear();
        CurrentEditContext.OnFieldChanged += (s, e) =>
            messageStore.Clear(e.FieldIdentifier);
    }

    public void DisplayErrors(Dictionary<string, List<string>> errors)
    {
        if (messageStore != null && CurrentEditContext != null)
        {
            foreach (var err in errors)
            {
                messageStore.Add(CurrentEditContext.Field(err.Key), err.Value);
            }

            CurrentEditContext.NotifyValidationStateChanged();
        }
    }

    public void ClearErrors()
    {
        if (messageStore != null && CurrentEditContext != null)
        {
            messageStore.Clear();
            CurrentEditContext.NotifyValidationStateChanged();
        }
    }
}