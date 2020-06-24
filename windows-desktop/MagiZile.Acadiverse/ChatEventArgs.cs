namespace MagiZile.Acadiverse
{
    public class ChatEventArgs
    {
        ChatMessage data;

        public ChatEventArgs(ChatMessage data)
        {
            this.data = data;
        }

        public ChatMessage Data { get => data; }
    }
}