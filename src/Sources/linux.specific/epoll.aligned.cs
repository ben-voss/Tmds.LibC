namespace Tmds.Linux
{
    public struct epoll_event
    {
        public int events;
        public epoll_data_t data;
    }
}