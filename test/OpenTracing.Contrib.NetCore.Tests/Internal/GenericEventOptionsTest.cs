using OpenTracing.Contrib.NetCore.Internal;
using Xunit;

namespace OpenTracing.Contrib.NetCore.Tests.Internal
{
    public class GenericEventOptionsTest
    {
        [Fact]
        public void IgnoreListenerTest()
        {
            const string listenerName = "ListenerName-1";

            var options = new GenericEventOptions();
            Assert.False(options.IsIgnored(listenerName));

            options.IgnoreListener(listenerName);

            Assert.True(options.IsIgnored(listenerName));
        }

        [Fact]
        public void IgnoreEventTest()
        {
            const string listenerName = "ListenerName-1";
            const string eventName = "EventName-1";

            var options = new GenericEventOptions();
            Assert.False(options.IsIgnored(listenerName));
            Assert.False(options.IsIgnored(listenerName, eventName));

            options.IgnoreEvent(listenerName, eventName);

            Assert.False(options.IsIgnored(listenerName));
            Assert.True(options.IsIgnored(listenerName, eventName));
        }
    }
}
