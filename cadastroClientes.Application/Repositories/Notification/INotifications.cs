using System;
using System.Collections.Generic;
using FluentValidation.Results;
using Domain = cadastroClientes.Domain.Commons;

namespace cadastroClientes.Application.Repositories.Notification
{
    public interface INotifications
    {
        List<Domain::Notification> Notifications { get; set; }
        bool HasNotifications { get; }
        void AddNotification(string key, string message);
        void AddNotifications(ValidationResult validationResult);
    }
}
