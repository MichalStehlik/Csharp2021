using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher pub = new EventPublisher(10);
            EventSubscriber sub = new EventSubscriber();
            pub.ValueHasChanged += sub.OnValueChanged;
            pub.ValueHasChanged += ReportChange;
            for (int i = 0; i < 10; i++)
            {
                pub.Value = i;
            }
            pub.ValueHasChanged -= ReportChange;
            for (int i = 10; i < 20; i++)
            {
                pub.Value = i;
            }
        }

        static void ReportChange(object sender, ExampleEventArgs e)
        {
            Console.WriteLine("It has changed to " + e.Value);
        }
    }
}
