using System;
using System.Text;

namespace Parlor_Library
{
    public abstract class Person // This abstract class can't be instantiated directly.
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public abstract string Contact(); // This method will require implementation on all subclasses, unlike an interface.
        public virtual string Card() // Example of a virtual method that we can optionally use in subclasses.
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("1");
            sb.AppendLine(Name);
            sb.AppendLine(EmailAddress);
            sb.AppendLine(TelephoneNumber);
            return sb.ToString();
        }

    }
    
    
}

