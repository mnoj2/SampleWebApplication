namespace SampleWebApp.Models {
    public abstract class Notification {
        public string Message { get; set; }

        public abstract string Send();
    }

    public class EmailNotification : Notification {
        public string RecipientEmail { get; set; }
        public override string Send() => $"Email sent to {RecipientEmail}: {Message}";
    }

    public class SMSNotification : Notification {
        public string PhoneNumber { get; set; }
        public override string Send() => $"SMS sent to {PhoneNumber}: {Message}";
    }
}
