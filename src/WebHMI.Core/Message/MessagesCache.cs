using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebHMI.Message
{
    public class MessagesCache
    {
        private ReaderWriterLockSlim cacheLock = new();
        private List<FlattenedMessage> messagesCache = [];
        private const int cacheLimit = 500;

        public void Add(FlattenedMessage message)
        {
            cacheLock.EnterWriteLock();
            try
            {
                messagesCache.Add(new FlattenedMessage(message));
                TrimCache();
            }
            finally
            {
                cacheLock.ExitWriteLock();
            }
        }

        public void Add(List<FlattenedMessage> messages)
        {
            cacheLock.EnterWriteLock();
            try
            {
                messagesCache.AddRange(messages.Select(x => new FlattenedMessage(x)));
                TrimCache();
            }
            finally
            {
                cacheLock.ExitWriteLock();
            }
        }

        public IEnumerable<FlattenedMessage> GetAll()
        {
            cacheLock.EnterReadLock();
            try
            {
                var result = messagesCache;
                return result;
            }
            finally
            {
                cacheLock.ExitReadLock();
            }
        }

        private void TrimCache()
        {
            if (messagesCache.Count > cacheLimit)
                messagesCache.RemoveRange(0, messagesCache.Count - cacheLimit);
        }
    }
}
