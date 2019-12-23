using System.Collections.Generic;

namespace PartyAtHomes_Lib
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            IsValid = true;
            Notifications = new List<Notification>();
        }
        public bool IsValid { get; set; }
        public ICollection<Notification> Notifications { get; set; }

        public void AddNotification(string message, string field, ValidationResultType type)
        {
            Notifications.Add(new Notification
            {
                Field = field,
                Message = message,
                Type = type
            });

            if(type == ValidationResultType.Error)
            {
                IsValid = false;
            }    
        }
    }

    public enum ValidationResultType
    {
        Succes = 1,
        Error = 2,
        Warning = 3,
    }

    public class Notification
    {
        public string Message { get; set; }
        public string Field { get; set; }
        public ValidationResultType Type { get; set; }
    }
}
