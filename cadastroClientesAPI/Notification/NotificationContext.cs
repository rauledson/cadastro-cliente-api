using System;
using System.Collections.Generic;
using Domain = cadastroClientes.Domain.Commons;
using FluentValidation.Results;
using cadastroClientes.Application.Repositories.Notification;
using System.Linq;

namespace cadastroClientesAPI.Notification
{
    public class NotificationContext : INotifications
    {
        public List<Domain::Notification> Notifications { get; set; }
        public bool HasNotifications => Notifications.Any();

        public NotificationContext()
        {
            Notifications = new List<Domain.Notification>();
        }

        public void AddNotification(string key, string message) => Notifications.Add(new Domain::Notification(key, message));

        public void AddNotifications(ValidationResult validationResult) => validationResult.Errors.ToList().ForEach(error => AddNotification(error.ErrorCode, error.ErrorMessage));

    }
}
