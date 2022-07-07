namespace Chat_App.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public Group Group { get; set; }
        public ICollection<MessageAttachment> Attachments { get; set; }
    }
}
